using System;
using System.Text;
using SimPe.Interfaces;
using SimPe.Interfaces.Plugin;
using System.Collections;

namespace SimPe.Plugin
{
    public class WrapperFactory3 : AbstractWrapperFactory, IToolFactory
    {
        public WrapperFactory3()
        {
        }

        public override SimPe.Interfaces.IWrapper[] KnownWrappers
        {
            get
            {
                return new IWrapper[0];
            }

        }
				
				public IToolPlugin[] KnownTools
				{
				      get
				      {
					      return new IToolPlugin[] { new SimPe.Plugin.SurgeryTool2(this.LinkedProvider) }; 
				      }
				
				 
				}

			}
}
