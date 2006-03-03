using System;
using System.Collections;

namespace SimPe.PackedFiles.Wrapper.Lua
{
	class Convert
	{
		public static double ToDouble(object o)
		{
			try 
			{
				return System.Convert.ToDouble(o);
			} 
			catch (Exception ex)
			{
				Console.WriteLine(ex+"\n\t Value was "+o.ToString());
			}
			return 0;
		}
	}
	class Global
	{
		string name;
		object val;
		public Global(string name, object val)
		{
			this.name = name;
			this.val = val;
		}

		public object Value
		{
			get {return val;}
			set {val = value;}
		}

		public override string ToString()
		{
			return name;
		}
	}

	class Table 
	{
		Hashtable data ;
		int sz0, sz1;
		public Table(int sz0, int sz1)
		{
			this.sz0 = sz0;
			this.sz1 = sz1;
			data = new Hashtable();
		}

		public override string ToString()
		{
			return "{}";
		}

		public  object this[object index]
		{
			get 
			{
				return data[index];
			}
			set 
			{
				object o = value;
				if (o==null) o = Context.Nil;
				data[index] = o;
			}		
		}	
	}

	class Context : System.IDisposable
	{
		class NULL 
		{
			public override string ToString()
			{
				return "nil";
			}

		}

	
		public Context CreateSubContext(ObjLuaFunction fkt, out string paramlist)
		{
			Context c = new Context(globals, indent+"\t");

			paramlist = "";
			if (fkt!=null) 
			{		
				int lc = 0;		
				for (int i=0; i<fkt.ArgumentCount; i++) 
				{		
					if (i>0) paramlist+= ", ";
					paramlist += "param"+i;

					c.ForceDefineLocal((ushort)lc, "param"+i);
					c.SetLocal((ushort)lc, 0.0);
					lc++;
				}

				/*for (int i=0; i<fkt.StackSize; i++) 
				{		
					c.ForceDefineLocal((ushort)lc, "stack"+i);
					c.SetLocal((ushort)lc, 0.0);
					lc++;
				}*/
			}

			return c;
		}

		static NULL nil = new NULL();
		public static object Nil
		{
			get {return nil;}
		}

		object[] regs;
		string[] sregs;
		Hashtable globals, localnames;
		int pc;
		string indent;
		public string Indent
		{
			get {return indent;}
		}

		public Context () : this (new Hashtable(), "") {}
		Context(Hashtable globals, string indent)
		{
			pc = 0;
			regs = new object[0xff];
			sregs = new string[regs.Length];
			
			for (int i=0; i<regs.Length; i++)	
			{
				sregs[i] = "{R"+i+"}";		
				regs[i] = nil;
			}
			
		
			this.globals = globals;
			localnames = new Hashtable();
			this.indent = indent;
		}

		public void SetSReg(ushort nr, string val)
		{
			if (val==null) val = "{R"+nr+"}";				
			sregs[nr] = val;			
		}	

		public void SetReg(ushort nr, object val)
		{
			if (val==null) val = nil;				
			regs[nr] = val;			
		}		

		public Table LoadTable(ushort regnr)
		{
			object o = R(regnr);
			if ( o is Global) o = ((Global)o).Value;
			return o as Table;
		}

		public object LoadTable(ushort regnr, object index)
		{
			Table tbl = LoadTable(regnr);
			if (tbl==null) 
				return Nil;
			return tbl[index];
		}

		public void SetTable(ushort regnr, object index, object val)
		{
			Table tbl = LoadTable(regnr);
			if (tbl!=null)			
				tbl[index] = val;			
		}

		public void SetGlobal(string name, object val)
		{
			if (val==null) val = nil;

			object o = globals[name];
			if (o==null)
				globals[name] = new Global(name, val);
			else 			
				((Global)o).Value = val;			
		}

		public void DefineLocal(ushort regnr)
		{
			DefineLocal(regnr, "myvar_"+regnr);
		}
		public void DefineLocal(ushort regnr, string name)
		{
			if (parent.IsLocalRegister(regnr, this))			
				ForceDefineLocal(regnr, name);			
		}

		void ForceDefineLocal(ushort regnr, string name)
		{
			localnames[name] = regnr;
			localnames[regnr] = name;			
		}

		public void SetLocal(ushort regnr, object val)
		{			
			if (!IsLocal(regnr)) DefineLocal(regnr);

			if (IsLocal(regnr)) SetSReg(regnr, LocalName(regnr));
			SetReg(regnr, val);
		}
		
		public bool IsLocal(ushort regnr)
		{
			return localnames[regnr]!=null;
		}

		public string LocalName(ushort regnr)
		{
			if (!IsLocal(regnr)) DefineLocal(regnr);
			return localnames[regnr].ToString();
		}

		public string SR(ushort val)
		{			
			if (IsLocal(val)) return LocalName(val);
			return sregs[val];
		}

		public string SRK(ushort v)
		{
			if (v<ObjLuaCode.RK_OFFSET) return SR(v);
			else return (SKst((uint)(v-ObjLuaCode.RK_OFFSET)));			
		}

		public object R(ushort val)
		{			
			//if (IsLocal(val)) return LocalName(val);
			return regs[val];
		}

		public object RK(ushort v)
		{
			if (v<ObjLuaCode.RK_OFFSET) return R(v);
			else return (Kst((uint)(v-ObjLuaCode.RK_OFFSET)));			
		}

		public object Gbl(object name)
		{
			if (name==null) name=nil;
			if (globals[name]==null) return name.ToString();
			return ((Global)globals[name]).Value;
		}

		public string SKst(uint v)
		{
			if (v>=0 && v<parent.Constants.Count) 
			{
				ObjLuaConstant oci = (ObjLuaConstant)parent.Constants[(int)v];
				if (oci.InstructionType==ObjLuaConstant.Type.String) return "\""+oci.String.Replace("\\", "\\\\")+"\"";
				else if (oci.InstructionType==ObjLuaConstant.Type.Number) return oci.Value.ToString();
				else return nil.ToString();				
			}
			return v.ToString();;
		}

		public object Kst(uint v) 
		{
			if (v>=0 && v<parent.Constants.Count) 
			{
				ObjLuaConstant oci = (ObjLuaConstant)parent.Constants[(int)v];
				if (oci.InstructionType==ObjLuaConstant.Type.String) return oci.String;
				else if (oci.InstructionType==ObjLuaConstant.Type.Number) return oci.Value;
				else return nil;				
			}
			return v.ToString();
		}
		

		public static int TblFbp(ushort v)
		{
			int m = (v & 0x00F8) >> 3;
			int b = (v & 0x0007);

			double d = b * Math.Pow(2, m);
			return (int)Math.Round(d);
		}

		public static int TblSz(ushort v)
		{
			return ((int)(Math.Log(5, 2) + 1));
		}

		public bool HasUpValue(ushort v)
		{
			return (v>=0 && v<parent.UpValues.Count);
		}

		public double UpValue(ushort v)
		{
			if (HasUpValue(v)) return Convert.ToDouble(parent.UpValues[v]);
			return 0;
		}

		public string ListR(int start, int end, string prefix)
		{
			if (end<start) return "";
			else 
			{
				string ret = "";
				for (int i=start; i<=end; i++)
				{
					if( i>start) ret+= ", ";
					ret += R((ushort)i);
				}

				return ret+prefix;
			}			
		}

		public string ListSR(int start, int end, string prefix)
		{
			if (end<start) return "";
			else 
			{
				string ret = "";
				for (int i=start; i<=end; i++)
				{
					if( i>start) ret+= ", ";
					ret += SR((ushort)i);
				}

				return ret+prefix;
			}			
		}

		public ObjLuaFunction KProto(uint nr)
		{
			if (nr<0 || nr>=parent.Functions.Count) return null;

			return parent.Functions[(int)nr] as ObjLuaFunction;
		}

		#region Used to iterate through the Codelines
		ObjLuaFunction parent;
		internal void Init(ObjLuaFunction parent)
		{
			this.parent = parent;
			pc = -1;
		}
		
		public int PC
		{
			get {return pc;}
		}

		public ObjLuaCode CurrentLine
		{
			get 
			{
				if (pc>=0 && pc<parent.Codes.Count)
					return parent.Codes[pc] as ObjLuaCode;
				else
					return null;
			}
		}

		public ObjLuaCode NextLine()
		{
			pc++;
			return CurrentLine;
		}

		public void PrepareJumpToEnd()
		{
			pc = GoToLastLine();
		}

		public void PrepareJumpToLine(int linenr)
		{
			pc = GoToLine(linenr)-1;
		}

		internal int GoToLastLine()
		{
			return GoToLine(parent.Codes.Count-1);			
		}

		internal int GoToLine(int linenr)
		{
			pc = linenr;
			return pc;
		}
		#endregion

		#region IDisposable Member

		public void Dispose()
		{
			regs = null;
			globals = null;
			localnames = null;
			sregs = null;
		}

		#endregion
	}

	interface IOperator
	{
		void Run(Context cx);
		string ToString(Context cx);
	}

	interface ILoadOperator
	{
		bool LoadsRegister(ushort regnr);
	}

	interface IIfOperator
	{
	}

	abstract class Operator : ObjLuaCode
	{
		public Operator(uint val, ObjLuaFunction parent) : base(val, parent){}		

		public virtual string ToString(Context cx)
		{
			return ToString();
		}	
	
		protected string AssignA(Context cx, object val)
		{
			if (cx.IsLocal(A)) 
			{
				return cx.LocalName(A) + " = " + val;
			}
			else if (R(A).ToString().StartsWith("{R"))
			{
				if (!ObjLuaFunction.DEBUG)	return "";
				return "// " + R(A) + " = " + val;
			}
			else
				return R(A) + " = " + val;
		}
	}
	

	class MOVE : Operator, IOperator
	{
		public MOVE(uint val, ObjLuaFunction parent) : base(val, parent){}

		public void Run(Context cx)
		{
			cx.SetReg(this.A, cx.R(this.B));
			cx.SetSReg(this.A, cx.SR(this.B));
		}

		public override string ToString(Context cx)
		{			
			if (A==B)
			{
				if (!ObjLuaFunction.DEBUG)	return "";
				return "/// " + AssignA(cx, cx.SR(B));
			}
			return AssignA(cx, cx.SR(B));			
		}	

		public override string ToString()
		{
			return R(A) + " = " + R(B);
		}
	}

	class LOADNIL : Operator, IOperator
	{
		public LOADNIL(uint val, ObjLuaFunction parent) : base(val, parent){}

		public void Run(Context cx)
		{
			for (ushort i=A; i<=B; i++) 
			{
				cx.SetReg(i, Context.Nil);			
				cx.SetSReg(i, Context.Nil.ToString());
			}
		}

		public override string ToString(Context cx)
		{
			bool haslocal = false;
			for (ushort i=A; i<=B; i++)			
				if (cx.IsLocal(i)) 
				{
					haslocal=true;
					break;
				}
			
			if (!ObjLuaFunction.DEBUG && !haslocal)	return "";
			string pref = "";
			if (!haslocal) pref = "// ";
			return pref + cx.ListSR(A, B, " = ") + Context.Nil.ToString();
		}


		public override string ToString()
		{
			return ListR(A, B, " = ", " , ..., ") + Context.Nil.ToString();
		}
	}

	class LOADK : Operator, IOperator, ILoadOperator
	{
		public LOADK(uint val, ObjLuaFunction parent) : base(val, parent){}

		public void Run(Context cx)
		{
			cx.SetLocal(A, cx.Kst(BX));	
			cx.SetSReg(A, cx.SKst(BX));
		}

		public override string ToString(Context cx)
		{				
			if (!cx.IsLocal(A))	cx.DefineLocal(A); //this fails, if this Register is used otherwise later
			if (cx.IsLocal(A))
				return "local "+cx.SR(A) +" = " + cx.SKst(BX);

			if (!ObjLuaFunction.DEBUG)	return "";
			return "// " + R(A) +" = " + cx.SKst(BX);
		}
		

		public override string ToString()
		{
			return R(A) +" = " + Kst(BX);
		}

		#region ILoadOperator Member

		public bool LoadsRegister(ushort regnr)
		{
			return A==regnr;
		}

		#endregion
	}

	class SETGLOBAL : Operator, IOperator
	{
		public SETGLOBAL(uint val, ObjLuaFunction parent) : base(val, parent){}

		public void Run(Context cx)
		{
			cx.SetGlobal(Kst(BX), cx.R(A));			
		}		

		public override string ToString(Context cx)
		{
			object o = cx.R(A);
			if (o is ObjLuaFunction) 
			{
				return cx.SR(A).Replace("{{name}}", Kst(BX));
			} 
			else 
			{
				return Kst(BX) + " = " + cx.SR(A);
			}
		}


		public override string ToString()
		{
			return Gbl(Kst(BX)) + " = " + R(A);
		}
	}

	class GETGLOBAL : Operator, IOperator, ILoadOperator
	{
		public GETGLOBAL(uint val, ObjLuaFunction parent) : base(val, parent){}

		public void Run(Context cx)
		{
			cx.SetReg(A, cx.Gbl(cx.Kst(BX)));	
			cx.SetSReg(A, Kst(BX));
		}	
		
		public override string ToString(Context cx)
		{
			if (!ObjLuaFunction.DEBUG)	return "";
			return "// " + R(A) + " = " + cx.Kst(BX);
		}

		public override string ToString()
		{
			return R(A) + " = " + Gbl(Kst(BX));
		}

		#region ILoadOperator Member

		public bool LoadsRegister(ushort regnr)
		{
			return A==regnr;
		}

		#endregion
	}
	
	class NEWTABLE : Operator, IOperator, ILoadOperator
	{
		public NEWTABLE(uint val, ObjLuaFunction parent) : base(val, parent){}

		public void Run(Context cx)
		{
			cx.SetReg(A, new Table(Context.TblFbp(B), Context.TblSz(C)));
			cx.SetSReg(A, "{}");
		}	
		
		public override string ToString(Context cx)
		{
			if (!ObjLuaFunction.DEBUG)	return "";
			return "// " + R(A) + " =new table["+TblFbp(B)+", "+TblSz(C)+"]";
		}

		public override string ToString()
		{
			return R(A) + " =new table["+TblFbp(B)+", "+TblSz(C)+"]";
		}

		#region ILoadOperator Member

		public bool LoadsRegister(ushort regnr)
		{
			return A==regnr;
		}

		#endregion
	}

	class SETTABLE : Operator, IOperator, ILoadOperator
	{
		public SETTABLE(uint val, ObjLuaFunction parent) : base(val, parent){}

		public void Run(Context cx)
		{
			cx.SetTable(A, cx.RK(B), cx.RK(C));			
		}	
		
		public override string ToString(Context cx)
		{
			object o = cx.RK(C);
			if (o is ObjLuaFunction) 
			{
				string s = cx.SRK(C).Replace("{{name}}", "function_"+cx.PC);
				s += "\n"+cx.Indent;
				s += cx.SR(A)+"["+cx.SRK(B)+"]" + " = " + "function_"+cx.PC;
				return s;
			} 
			else 
			{
				return cx.SR(A)+"["+cx.SRK(B)+"]" + " = " + cx.SRK(C);
			}
			
		}

		public override string ToString()
		{
			return R(A)+"["+RK(B)+"]" + " = " + RK(C);
		}

		#region ILoadOperator Member

		public bool LoadsRegister(ushort regnr)
		{
			return A==regnr;
		}

		#endregion
	}

	class GETTABLE : Operator, IOperator, ILoadOperator
	{
		public GETTABLE(uint val, ObjLuaFunction parent) : base(val, parent){}

		public void Run(Context cx)
		{
			cx.SetReg(A, cx.LoadTable(B, cx.RK(C)));	
			cx.SetSReg(A, cx.SR(B)+"["+cx.SRK(C)+"]");
		}	
		
		public override string ToString(Context cx)
		{
			/*if (!ObjLuaFunction.DEBUG)	return "";
			return "// " + R(A) + " = " + cx.SR(B)+"["+cx.SRK(C)+"]";*/

			return AssignA(cx, cx.SR(B)+"["+cx.SRK(C)+"]");
		}

		public override string ToString()
		{
			return R(A) + " = " + R(B)+"["+RK(C)+"]";
		}	
	
		#region ILoadOperator Member

		public bool LoadsRegister(ushort regnr)
		{
			return A==regnr;
		}

		#endregion
	}

	class CALL : Operator, IOperator
	{
		public CALL(uint val, ObjLuaFunction parent) : base(val, parent){}

		public void Run(Context cx)
		{
			//cx.SetReg(this.A, cx.R(this.B));
			for (int i=A; i<=A+C-2; i++)
			{
				cx.SetReg((ushort)i, Context.Nil);
				cx.SetSReg((ushort)i, cx.SR(A) + "(" + cx.ListSR(A+1, A+B-1, "") + ")"/*+".Result["+i+"]"*/);
			}
			
		}

		public override string ToString(Context cx)
		{	
			string content = cx.SR(A) + "(" + cx.ListSR(A+1, A+B-1, "") + ")";
			bool haslocal = false;
			for (ushort i=A; i<=A+C-2; i++) 
			{
				if (!cx.IsLocal(i))	cx.DefineLocal(i); //this fails, if this Register is used otherwise later
				if (cx.IsLocal(i)) haslocal=true;
			}

			if (A<=A+C-2) 
			{
				if (!haslocal)
				{
					if (!ObjLuaFunction.DEBUG)	return "";
					return "// " + ListR(A, A+C-2, " = ", ", ... ,") + content;
				} 
				else 
				{
					string ret = "";
					for (ushort i=A; i<=A+C-2; i++) 
					{
						if (i>A) ret += ",";
						if (cx.IsLocal(i)) ret += cx.LocalName(i);
						else ret += R(i);
					}

					return ret + " = " + content;
				}
			}

			return content;
		}

		public override string ToString()
		{
			return ListR(A, A+C-2, " = ", ", ..., ") + R(A) + "(" + ListR(A+1, A+B-1, "", ", ..., ") + ")";
		}
	}

	class RETURN : Operator, IOperator
	{
		public RETURN(uint val, ObjLuaFunction parent) : base(val, parent){}

		public void Run(Context cx)
		{
			cx.PrepareJumpToEnd();
		}

		public override string ToString(Context cx)
		{			
			return "return " + cx.ListSR(A, A+B-2, "");
		}

		public override string ToString()
		{
			return "return " + ListR(A, A+B-2, "", ", ..., ");
		}
	}

	class CLOSURE : Operator, IOperator
	{
		public CLOSURE(uint val, ObjLuaFunction parent) : base(val, parent){}

		public void Run(Context cx)
		{
			ObjLuaFunction fkt = cx.KProto(BX);
			cx.SetReg(this.A, fkt);

			System.IO.StreamWriter sw = new System.IO.StreamWriter(new System.IO.MemoryStream());
			string paramlist;
			Context scx = cx.CreateSubContext(fkt, out paramlist);
			sw.WriteLine();
			sw.WriteLine(cx.Indent+"function {{name}}("+paramlist+")");
			fkt.ToSource(sw, scx);
			sw.Write(cx.Indent+"end");
			sw.WriteLine();

			sw.Flush();
			sw.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
			System.IO.StreamReader sr = new System.IO.StreamReader(sw.BaseStream);
			cx.SetSReg(A, sr.ReadToEnd());
			sw.Close();
		}

		public override string ToString(Context cx)
		{			
			if (!ObjLuaFunction.DEBUG)	return "";
			return "// " + R(A) + " = closure(KPROTO["+BX.ToString()+"])";
		}

		public override string ToString()
		{
			return R(A) + " = closure(KPROTO["+BX.ToString()+"])";
		}
	}

	class ADD : Operator, IOperator
	{
		public ADD(uint val, ObjLuaFunction parent) : base(val, parent){}

		public void Run(Context cx)
		{
			cx.SetReg(this.A, Convert.ToDouble(cx.RK(this.B)) + Convert.ToDouble(cx.RK(this.C)));
			cx.SetSReg(A, "("+cx.SRK(B) +" + "+ cx.SRK(C)+")");
		}

		public override string ToString(Context cx)
		{					
			if (cx.IsLocal(A))
				return cx.LocalName(A) + " = " + cx.SRK(B) + " + " + cx.SRK(C);
			else
			{
				if (!ObjLuaFunction.DEBUG)	return "";
				return "// " + R(A) + " = " + cx.SRK(B) + " + " + cx.SRK(C);
			}
		}	

		public override string ToString()
		{
			return R(A) + " = " + RK(B) + " + " + RK(C);
		}
	}

	class SUB : Operator, IOperator
	{
		public SUB(uint val, ObjLuaFunction parent) : base(val, parent){}

		public void Run(Context cx)
		{
			cx.SetReg(this.A, Convert.ToDouble(cx.RK(this.B)) - Convert.ToDouble(cx.RK(this.C)));			
			cx.SetSReg(A, "("+cx.SRK(B) +" - "+ cx.SRK(C)+")");
		}

		public override string ToString(Context cx)
		{					
			
			if (cx.IsLocal(A))
				return cx.LocalName(A) + " = " + cx.SRK(B) + " - " + cx.SRK(C);
			else
			{
				if (!ObjLuaFunction.DEBUG)	return "";
				return "// " + R(A) + " = " + cx.SRK(B) + " - " + cx.SRK(C);
			}
		}	

		public override string ToString()
		{
			return R(A) + " = " + RK(B) + " - " + RK(C);
		}
	}

	class MUL : Operator, IOperator
	{
		public MUL(uint val, ObjLuaFunction parent) : base(val, parent){}

		public void Run(Context cx)
		{
			cx.SetReg(this.A, Convert.ToDouble(cx.RK(this.B)) * Convert.ToDouble(cx.RK(this.C)));
			cx.SetSReg(A, "("+cx.SRK(B) +" * "+ cx.SRK(C)+")");
		}

		public override string ToString(Context cx)
		{					
			if (cx.IsLocal(A))
				return cx.LocalName(A) + " = " + cx.SRK(B) + " * " + cx.SRK(C);
			else
			{
				if (!ObjLuaFunction.DEBUG)	return "";
				return "// " + R(A) + " = " + cx.SRK(B) + " * " + cx.SRK(C);
			}
		}	

		public override string ToString()
		{
			return R(A) + " = " + RK(B) + " * " + RK(C);
		}
	}

	class DIV : Operator, IOperator
	{
		public DIV(uint val, ObjLuaFunction parent) : base(val, parent){}

		public void Run(Context cx)
		{
			cx.SetReg(this.A, Convert.ToDouble(cx.RK(this.B)) / Convert.ToDouble(cx.RK(this.C)));
			cx.SetSReg(A, "("+cx.SRK(B) +" / "+ cx.SRK(C)+")");
		}

		public override string ToString(Context cx)
		{					
			if (cx.IsLocal(A))
				return cx.LocalName(A) + " = " + cx.SRK(B) + " / " + cx.SRK(C);
			else
			{
				if (!ObjLuaFunction.DEBUG)	return "";
				return "// " + R(A) + " = " + cx.SRK(B) + " / " + cx.SRK(C);
			}
		}	

		public override string ToString()
		{
			return R(A) + " = " + RK(B) + " / " + RK(C);
		}
	}

	class GETUPVAL : Operator, IOperator, ILoadOperator
	{
		public GETUPVAL(uint val, ObjLuaFunction parent) : base(val, parent){}

		public void Run(Context cx)
		{
			cx.SetReg(A, cx.Gbl(cx.Kst(BX)));	
			cx.SetSReg(A, Kst(BX));
		}	
		
		public override string ToString(Context cx)
		{
			if (!cx.HasUpValue(B)) 
			{
				if (!ObjLuaFunction.DEBUG)	return "";
				return "/// " + AssignA(cx, cx.UpValue(B));
			} else
				return AssignA(cx, cx.UpValue(B));
		}

		public override string ToString()
		{
			return R(A) + " = " + UpValue(B);
		}

		#region ILoadOperator Member

		public bool LoadsRegister(ushort regnr)
		{
			return A==regnr;
		}

		#endregion
	}
	
	class JMP : Operator, IOperator
	{
		public JMP(uint val, ObjLuaFunction parent) : base(val, parent){}

		public void Run(Context cx)
		{
			cx.PrepareJumpToLine(cx.PC + SBX);
		}

		public override string ToString(Context cx)
		{					
			if (!ObjLuaFunction.DEBUG)	return "";
			return "// " +"PC += " + SBX.ToString();
		}	

		public override string ToString()
		{
			return "PC += " + SBX.ToString();
		}
	}

	class IF : Operator, IIfOperator
	{
		string symb, nsymb;
		public IF(string symb, string nsymb, uint val, ObjLuaFunction parent) : base(val, parent){
			this.symb = symb;
			this.nsymb = nsymb;
		}

		public override string ToString(Context cx)
		{					
			if (Bool(A)=="true")
				return "if (" + cx.SRK(B) + " "+nsymb+" " + cx.SRK(C) + ") then";
			else
				return "if (" + cx.SRK(B) + " "+symb+" " + cx.SRK(C) + ") then";
		}	

		public override string ToString()
		{
			return "if ((" + RK(B) + " "+symb+" " + RK(C) + ") == " + Bool(A) + ") then PC++";
		}
	}

	class EQ : IF, IOperator
	{
		public EQ(uint val, ObjLuaFunction parent) : base("==", "!=", val, parent){}

		public void Run(Context cx)
		{
			
		}		
	}

	class LE : IF, IOperator
	{
		public LE(uint val, ObjLuaFunction parent) : base("<=", ">", val, parent){}

		public void Run(Context cx)
		{
			
		}		
	}

	class GE : IF, IOperator
	{
		public GE(uint val, ObjLuaFunction parent) : base(">=", "<", val, parent){}

		public void Run(Context cx)
		{
			
		}		
	}

	class LT : IF, IOperator
	{
		public LT(uint val, ObjLuaFunction parent) : base("<", ">=", val, parent){}

		public void Run(Context cx)
		{
			
		}		
	}

	class GT : IF, IOperator
	{
		public GT(uint val, ObjLuaFunction parent) : base(">", "<=", val, parent){}

		public void Run(Context cx)
		{
			
		}		
	}
}
