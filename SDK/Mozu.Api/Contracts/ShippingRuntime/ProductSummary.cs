
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


namespace Mozu.Api.Contracts.ShippingRuntime
{
		public class ProductSummary
		{
			public string ProductCode { get; set; }

			public string ProductType { get; set; }

			public List<Category> Categories { get; set; }

			public List<ProductOption> Options { get; set; }

			public List<ProductProperty> Properties { get; set; }

			public ItemMeasurements UnitMeasurements { get; set; }

		}

}