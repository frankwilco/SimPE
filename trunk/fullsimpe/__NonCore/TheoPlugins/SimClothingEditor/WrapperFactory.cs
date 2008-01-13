using System;
using System.Text;
using SimPe.Interfaces;
using SimPe.Interfaces.Plugin;
using System.Collections;

namespace SimPe.Plugin
{
	public class WrapperFactory : AbstractWrapperFactory, IToolFactory
	{
		public WrapperFactory()
		{
		}

		public override IWrapper[] KnownWrappers
		{
			get { return new IWrapper[0]; }

		}

		public IToolPlugin[] KnownTools
		{
			get
			{
				return new IToolPlugin[] {
					new SimClothingTool(this.LinkedRegistry, this.LinkedProvider)
				};
			}
		}



	}


}
