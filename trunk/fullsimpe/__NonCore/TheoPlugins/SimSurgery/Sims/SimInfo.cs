using System;
using System.Collections.Generic;
using System.Text;
using SimPe.PackedFiles.Wrapper;
using SimPe.Data;
using System.ComponentModel;
using SimPe.Plugin.Wrapper;

namespace SimPe.Plugin
{
	/// <summary>
	/// A simple info object for PropertyGrid presentation purposes.
	/// </summary>
	internal sealed class SimInfo
	{
		Cpf ageData;
		string name;
		string filename;

		[Category("General")]
		public Ages Age
		{
			get { return (Ages)ageData.GetItem("age").UIntegerValue; }
		}

		[Category("General")]
		public SimGender Gender
		{
			get { return (SimGender)ageData.GetItem("gender").UIntegerValue; }
		}

		[Category("General")]
		public string Name
		{
			get { return this.name; }
		}

		[Category("General")]
		public string Filename
		{
			get { return this.filename; }
		}

		[Category("Genetics")]
		public string Hair
		{
			get { return ageData.GetItem("haircolor").StringValue; }
		}

		[Category("Genetics")]
		public string Eyes
		{
			get { return ageData.GetItem("eyecolor").StringValue; }
		}

		[Category("Genetics")]
		public string Skin
		{
			get { return ageData.GetItem("skincolor").StringValue; }
		}
		
	
		public SimInfo(Cpf aged, string filename, string name)
		{
			if (aged == null)
				throw new ArgumentNullException();
			this.ageData = aged;
			this.filename = filename;
			this.name = name;
		}



	}
}
