using System;
using System.ComponentModel;
using System.Globalization;

namespace SimPe
{
	/// <summary>
	/// Used for dynamic PropertyGrids using <see cref="SimPe.FlagBase"/> Objects.
	/// </summary>
	public class FlagBaseConverter : System.ComponentModel.ExpandableObjectConverter 
	{
		public override bool CanConvertTo(ITypeDescriptorContext context,
			System.Type destinationType) 
		{
			if (destinationType == typeof(SimPe.FlagBase))
				return true;

			return base.CanConvertTo(context, destinationType);
		}

		public override object ConvertTo(ITypeDescriptorContext context,
			CultureInfo culture, 
			object value, 
			System.Type destinationType) 
		{
			if (destinationType == typeof(System.String) && 
				value is SimPe.FlagBase)
			{				
				return Helper.MinStrLength(value.ToString(), 16);
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		public override bool CanConvertFrom(ITypeDescriptorContext context,
			System.Type sourceType) 
		{
			if (sourceType == typeof(string))
				return true;

			return base.CanConvertFrom(context, sourceType);
		}

		public override object ConvertFrom(ITypeDescriptorContext context,
			CultureInfo culture, object value) 
		{
			if (value is string) 
			{
				try 
				{				
					ushort s = Convert.ToUInt16((string)value, 2);
					return System.Activator.CreateInstance(context.PropertyDescriptor.PropertyType, new object[] {s});					
				}
				catch 
				{
					throw new ArgumentException(
						"Can not convert '" + (string)value + "'. This is not a valid Flag Value!");						
				}
			}  
			return base.ConvertFrom(context, culture, value);
		}
	}
}
