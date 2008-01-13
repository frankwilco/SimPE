using System;
using System.Text;
using SimPe.Interfaces;
using SimPe.Interfaces.Plugin;
using System.Collections;

namespace SimPe.Plugin
{
	public class WrapperFactory : AbstractWrapperFactory, IToolFactory, ISettingsFactory
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
					new SurgeryToolExt(this.LinkedRegistry, this.LinkedProvider)
				};
			}
		}


		public ISettings[] KnownSettings
		{
			get {
				return new ISettings[] {
					PackageBrowserSettings.Instance
				};
			}
		}


	}


}
