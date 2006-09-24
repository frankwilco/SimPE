using System;
using System.IO;
using System.Reflection;
using Microsoft.CSharp; 
using System.CodeDom.Compiler; 

namespace SimPe
{
    /// <summary>
    /// Class that offers method allowing you to simply compile c# sourcecode at runtime
    /// </summary>
    public static class RuntimeCompiler
    {
        /// <summary>
        /// Compiles C# Code at runtime
        /// </summary>
        /// <param name="s">Your Code</param>
        /// <returns></returns>
        /// <remarks>based on http://www.csharpfriends.com/Articles/getArticle.aspx?articleID=118</remarks>
        public static Assembly Compile(string s)
        {
            return Compile(s, new string[0]);
        }

        /// <summary>
        /// Compiles C# Code at runtime
        /// </summary>
        /// <param name="s">Your Code</param>
        /// <param name="referenced">List of references Assemblies</param>
        /// <returns></returns>
        /// <remarks>based on http://www.csharpfriends.com/Articles/getArticle.aspx?articleID=118</remarks>
        public static Assembly Compile(string s, string[] referenced)
        {
            string flname = System.IO.Path.GetTempFileName();



            // Create the C# compiler
            CodeDomProvider iCodeCompiler = new CSharpCodeProvider();


            // input params for the compiler
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.GenerateExecutable = false;
            compilerParams.IncludeDebugInformation = true;


            compilerParams.ReferencedAssemblies.Add("system.dll");
            compilerParams.ReferencedAssemblies.Add("system.data.dll");
            compilerParams.ReferencedAssemblies.Add("system.xml.dll");
            foreach (string rs in referenced)
                compilerParams.ReferencedAssemblies.Add(rs);


            // Run the compiler and build the assembly
            CompilerResults res = iCodeCompiler.CompileAssemblyFromSource(compilerParams, s);

            if (res.Errors.Count > 0)
            {
                foreach (object o in res.Errors)
                    Console.WriteLine(o);

                return null;
            }


            return res.CompiledAssembly;
        }

        /// <summary>
        /// Instanciate a class in an assembly
        /// </summary>
        /// <param name="asm">The assembly that contains the class</param>
        /// <param name="name">The name of the class</param>
        /// <param name="args">The arguments passed to the constructor of the class</param>
        /// <returns>null on error or the instance of the passed class</returns>
        public static object CreateInstance(Assembly asm, string name, object[] args)
        {
            Type t = asm.GetType(name, false);
            if (t == null) return null;

            return System.Activator.CreateInstance(t, args);
        }
    }

}
