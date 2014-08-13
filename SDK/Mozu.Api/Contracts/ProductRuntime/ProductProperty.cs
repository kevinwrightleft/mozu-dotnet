
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;


namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	Details of a property attribute defined for a product.
		///
		public class ProductProperty
		{
			///
			///The fully qualified name of the attribute, which is a user defined attribute identifier.
			///
			public string AttributeFQN { get; set; }

			///
			///If true, the product property does not appear for the product in the storefront.
			///
			public bool? IsHidden { get; set; }

			///
			///If true, the product property can have more than one selected value.
			///
			public bool? IsMultiValue { get; set; }

			///
			///Details of the attribute defined as a product property.
			///
			public AttributeDetail AttributeDetail { get; set; }

			///
			///List of values defined for the product property attribute.
			///
			public List<ProductPropertyValue> Values { get; set; }

		}

}