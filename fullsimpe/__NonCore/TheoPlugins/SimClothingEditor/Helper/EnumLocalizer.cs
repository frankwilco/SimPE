using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using System.Reflection;

namespace SimPe.Plugin.Helper
{

	/// <summary>
	/// Used to localize Enum member descriptions
	/// </summary>
	public sealed class EnumLocalizer : LocalizableObject
	{
		ResourceManager resources;

		string resourceRoot;
		Assembly baseAssembly;
		Type enumType;

		public Type EnumType
		{
			get { return this.enumType; }
			set
			{
				if (value == null || !value.IsEnum)
					throw new ArgumentException("The provided Type must be a System.Enum");
				this.enumType = value;
			}
		}

		public string ResourceBaseName
		{
			get { return this.resourceRoot; }
			set { this.resourceRoot = value; }
		}

		public Assembly ResourceAssembly
		{
			get { return this.baseAssembly; }
			set { this.baseAssembly = value; }
		}

		ResourceManager Resources
		{
			get
			{
				if (this.resources == null)
				{
					if (this.resourceRoot != null && this.baseAssembly != null)
						this.resources = new ResourceManager(this.resourceRoot, this.baseAssembly);
					else
						this.resources = new ResourceManager(typeof(EnumLocalizer));
				}
				return this.resources;
			}
		}

		public EnumDescription this[Enum enumValue]
		{
			get	{ return GetEnumDescription(enumValue); }
		}


		public EnumLocalizer(Type enumType) : this(enumType, CultureInfo.CurrentUICulture)
		{
		}

		public EnumLocalizer(Type enumType, CultureInfo culture) : this(enumType, culture, null)
		{
		}

		public EnumLocalizer(Type enumType, CultureInfo culture, string resourceRoot) : this(enumType, culture, resourceRoot, Assembly.GetExecutingAssembly())
		{

		}

		public EnumLocalizer(Type enumType, CultureInfo culture, string resourceRoot, Assembly baseAssembly)
		{
			this.EnumType = enumType;
			this.Culture = culture;
			this.resourceRoot = resourceRoot;
			this.baseAssembly = baseAssembly;
		}

		public EnumDescription GetEnumDescription(Enum enumValue)
		{
			if (enumValue == null)
				throw new ArgumentNullException();

			if (enumValue.GetType() != this.enumType)
				throw new ArgumentException(String.Format("The parameter must be of type {0}", this.enumType.FullName));

			string ret = enumValue.ToString();
			string resKey = String.Format("${0}.{1}", this.enumType.FullName, enumValue);
			try
			{
				ret = this.Resources.GetString(resKey, this.Culture);
			}
			catch
			{
				// description not provided
			}
			return new EnumDescription(enumValue, ret);
		}



	}


	public sealed class EnumDescription
	{
		Enum value;
		string text;

		public Enum Value
		{
			get { return this.value; }
		}

		public string Text
		{
			get { return this.text; }
		}

		public EnumDescription(Enum value, string text)
		{
			this.value = value;
			this.text = text;
		}

		public override string ToString()
		{
			return this.text;
		}



	}


}
