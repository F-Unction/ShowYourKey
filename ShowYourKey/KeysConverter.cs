using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;

namespace ShowYourKey
{
	/// <summary>Provides a <see cref="T:System.ComponentModel.TypeConverter" /> to convert <see cref="T:System.Windows.Forms.Keys" /> objects to and from other representations.</summary>
	// Token: 0x020001AF RID: 431
	public class KeysConverter : TypeConverter, IComparer
	{
		/// <summary>Returns a value indicating whether this converter can convert an object in the specified source type to the native type of the converter using the specified context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context, which can be used to extract additional information about the environment this converter is being invoked from. This parameter or properties of this parameter can be <see langword="null" />.</param>
		/// <param name="sourceType">The <see cref="T:System.Type" /> to convert from.</param>
		/// <returns>
		///   <see langword="true" /> if the conversion can be performed; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002381 RID: 9089 RVA: 0x00004050 File Offset: 0x00000650
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			throw null;
		}

		/// <summary>Returns a value indicating whether this converter can convert an object in the specified source type to the native type of the converter using the specified context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context, which can be used to extract additional information about the environment this converter is being invoked from. This parameter or properties of this parameter can be <see langword="null" />.</param>
		/// <param name="destinationType">The <see cref="T:System.Type" /> to convert to.</param>
		/// <returns>
		///   <see langword="true" /> if the conversion can be performed; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002382 RID: 9090 RVA: 0x00004050 File Offset: 0x00000650
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			throw null;
		}

		/// <summary>Compares two key values for equivalence.</summary>
		/// <param name="a">An <see cref="T:System.Object" /> that represents the first key to compare.</param>
		/// <param name="b">An <see cref="T:System.Object" /> that represents the second key to compare.</param>
		/// <returns>An integer indicating the relationship between the two parameters.  
		///
		///  <list type="table"><listheader><term> Value Type</term><description> Condition</description></listheader><item><term> A negative integer.</term><description><paramref name="a" /> is less than <paramref name="b" />.</description></item><item><term>0</term><description><paramref name="a" /> equals <paramref name="b" />.</description></item><item><term> A positive integer.</term><description><paramref name="a" /> is greater than <paramref name="b" />.</description></item></list></returns>
		// Token: 0x06002383 RID: 9091 RVA: 0x00004050 File Offset: 0x00000650
		public int Compare(object a, object b)
		{
			throw null;
		}

		/// <summary>Converts the specified object to the converter's native type.</summary>
		/// <param name="context">An <see langword="ITypeDescriptorContext" /> that provides a format context, which can be used to extract additional information about the environment this converter is being invoked from. This parameter or properties of this parameter can be null.</param>
		/// <param name="culture">A <see langword="CultureInfo" /> object to provide locale information.</param>
		/// <param name="value">The object to convert.</param>
		/// <exception cref="T:System.FormatException">An invalid key combination was supplied.  
		///
		///  -or-  
		///
		///  An invalid key name was supplied.</exception>
		/// <returns>An object that represents the converted <paramref name="value" />.</returns>
		// Token: 0x06002384 RID: 9092 RVA: 0x00004050 File Offset: 0x00000650
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			throw null;
		}

		/// <summary>Converts the specified object to the specified destination type.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context, which can be used to extract additional information about the environment this converter is being invoked from. This parameter or properties of this parameter can be <see langword="null" />.</param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> to provide locale information.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
		/// <param name="destinationType">The <see cref="T:System.Type" /> to convert the object to.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="destinationType" /> is <see langword="null" />.</exception>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted <paramref name="value" />.</returns>
		// Token: 0x06002385 RID: 9093 RVA: 0x00004050 File Offset: 0x00000650
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			throw null;
		}

		/// <summary>Returns a collection of standard values for the data type that this type converter is designed for when provided with a format context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context, which can be used to extract additional information about the environment this converter is being invoked from. This parameter or properties of this parameter can be <see langword="null" />.</param>
		/// <returns>A <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" /> that holds a standard set of valid values, which can be empty if the data type does not support a standard set of values.</returns>
		// Token: 0x06002386 RID: 9094 RVA: 0x00004050 File Offset: 0x00000650
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			throw null;
		}

		/// <summary>Determines if the list of standard values returned from <see langword="GetStandardValues" /> is an exclusive list using the specified <see cref="T:System.ComponentModel.ITypeDescriptorContext" />.</summary>
		/// <param name="context">A formatter context. This object can be used to extract additional information about the environment this converter is being invoked from. This may be <see langword="null" />, so you should always check. Also, properties on the context object may also return <see langword="null" />.</param>
		/// <returns>
		///   <see langword="true" /> if the collection returned from <see cref="Overload:System.Windows.Forms.KeysConverter.GetStandardValues" /> is an exhaustive list of possible values; otherwise, <see langword="false" /> if other values are possible. The default implementation for this method always returns <see langword="false" />.</returns>
		// Token: 0x06002387 RID: 9095 RVA: 0x00004050 File Offset: 0x00000650
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			throw null;
		}

		/// <summary>Gets a value indicating whether this object supports a standard set of values that can be picked from a list.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context, which can be used to extract additional information about the environment this converter is being invoked from. This parameter or properties of this parameter can be <see langword="null" />.</param>
		/// <returns>Always returns <see langword="true" />.</returns>
		// Token: 0x06002388 RID: 9096 RVA: 0x00004050 File Offset: 0x00000650
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			throw null;
		}

		/// <summary>Initializes an instance of the <see cref="T:System.Windows.Forms.KeysConverter" /> class.</summary>
		// Token: 0x06002389 RID: 9097 RVA: 0x00004050 File Offset: 0x00000650
		public KeysConverter()
		{
			throw null;
		}
	}
}
