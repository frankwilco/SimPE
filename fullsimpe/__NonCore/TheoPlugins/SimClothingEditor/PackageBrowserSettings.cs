using System;
using System.Collections.Generic;
using System.Text;
using SimPe.Interfaces;
using System.Windows.Forms;
using SimPe.Plugin.UI;
using System.ComponentModel;
using System.Resources;

namespace SimPe.Plugin
{

	/// <summary>
	/// The Preferences for the packages browser
	/// </summary>
	public sealed class PackageBrowserSettings : SimPe.GlobalizedObject, ISettings
	{
		static PackageBrowserSettings instance = new PackageBrowserSettings();
		static ResourceManager rm;
		const string RegistryKey = "PackageBrowser";

		XmlRegistryKey xrk;

		static ResourceManager Resources
		{
			get
			{
				if (rm == null)
					rm = new ResourceManager(typeof(PackageBrowserSettings));
				return rm;
			}
		}

		public static PackageBrowserSettings Instance
		{
			get { return instance; }
		}

		PackageBrowserSettings()
			: base(Resources)
		{
			xrk = SimPe.Helper.WindowsRegistry.PluginRegistryKey;
		}


		[Category("View")]
		public View ViewMode
		{
			get
			{
				XmlRegistryKey rkf = xrk.CreateSubKey(RegistryKey);
				object o = rkf.GetValue("ViewMode", View.LargeIcon);
				if (o is string)
					return (View)Enum.Parse(typeof(View), (string)o);
				return (View)o;
			}
			set
			{
				XmlRegistryKey rkf = xrk.CreateSubKey(RegistryKey);
				rkf.SetValue("ViewMode", value);
			}
		}

		[Category("View")]
		public bool ShowHiddenItems
		{
			get
			{
				XmlRegistryKey rkf = xrk.CreateSubKey(RegistryKey);
				object o = rkf.GetValue("ShowHidden", false);
				return Convert.ToBoolean(o);
			}
			set
			{
				XmlRegistryKey rkf = xrk.CreateSubKey(RegistryKey);
				rkf.SetValue("ShowHidden", value);
			}
		}


		#region ISettings Member

		object ISettings.GetSettingsObject()
		{
			return this;
		}

		public override string ToString()
		{
			return rm.GetString("$this.Text");
		}

		System.Drawing.Image ISettings.Icon
		{
			get	{	return null; }
		}

		#endregion

	}
}
