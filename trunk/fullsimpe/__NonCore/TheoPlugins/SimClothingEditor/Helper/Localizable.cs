using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Threading;
using System.Resources;

namespace SimPe.Plugin.Helper
{

	/// <summary>
	/// Non-static version of <see cref="SimPe.Localization"/>.
	/// </summary>
	/// <remarks>
	/// Classes that output string messages to the UI should derive from this class,
	/// when the design goal is resource de-centralization.
	/// Override the <see cref="ResourceType"/> property to define
	/// where the <see cref="ResourceManager"/> will get the resource set.
	/// </remarks>
	public abstract class LocalizableObject : ILocalizable
	{
		ResourceManager resources;
		CultureInfo culture;

		protected virtual Type ResourceType
		{
			get { return this.GetType(); }
		}

		protected ResourceManager ResourceManager
		{
			get {
				if (this.resources == null)
					this.resources = new ResourceManager(this.ResourceType);
				return this.resources;
			}
		}

		protected CultureInfo Culture
		{
			get
			{
				if (this.culture == null)
					this.culture = CultureInfo.CurrentUICulture;
				return this.culture;
			}
			set
			{
				this.culture = value;
			}
		}

		protected LocalizableObject()
		{
		}

		protected string GetString(string key)
		{
			if (key == null)
				throw new ArgumentNullException();

			try
			{
				string ret = this.ResourceManager.GetString(key, this.Culture);
				if (ret != null)
					return ret;
			}
			catch
			{
			}
			return key;
		}

		protected T GetObject<T>(string key)
		{
			if (key == null)
				throw new ArgumentNullException();

			try
			{
				object ret = this.ResourceManager.GetObject(key, this.Culture);
				return (T)ret;
			}
			catch
			{
			}
			return default(T);
		}

		#region ILocalizable Members

		ResourceManager ILocalizable.ResourceManager
		{
			get { return this.ResourceManager; }
		}

		CultureInfo ILocalizable.Culture
		{
			get { return this.Culture; }
			set { this.Culture = value; }
		}

		string ILocalizable.GetString(string key)
		{
			return this.GetString(key);
		}

		#endregion
	}

	public interface ILocalizable
	{
		System.Resources.ResourceManager ResourceManager { get; }

		System.Globalization.CultureInfo Culture { get; set; }

		string GetString(string key);
	}
}
