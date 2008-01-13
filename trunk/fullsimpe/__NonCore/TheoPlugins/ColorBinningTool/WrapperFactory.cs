using System;
using SimPe.Interfaces;
using SimPe.Interfaces.Plugin;

namespace SimPe.Plugin
{
	/// <summary>
	/// Summary description for Wrapper.
	/// </summary>
	public class WrapperFactory : AbstractWrapperFactory, IToolFactory
	{

		public WrapperFactory()
		{
			
		}


		public SimPe.Interfaces.IToolPlugin[] KnownTools
		{
			get
			{
				return new IToolPlugin[] { new GeneticCategorizerTool() };
			}
		}


		string IToolFactory.FileName
		{
			get
			{
				return "Genetic Categorizer Tool";
			}
		}


	}


}
