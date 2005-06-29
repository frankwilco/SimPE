using System;

namespace SimPe.Interfaces
{
	/// <summary>
	/// Abstract Implementation for <see cref="SimPe.Interfaces.IToolExt"/> classes
	/// </summary>
	public abstract class AbstractTool : SimPe.Interfaces.IToolExt
	{
		
		#region IToolExt Member

		public virtual System.Drawing.Image Icon
		{
			get {return null;}
		}

		public virtual System.Windows.Forms.Shortcut Shortcut
		{
			get
			{
				return System.Windows.Forms.Shortcut.None;
			}
		}

		#endregion				
	}
}
