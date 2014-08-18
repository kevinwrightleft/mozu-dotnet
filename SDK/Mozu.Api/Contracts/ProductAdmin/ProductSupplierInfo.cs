
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Supplier-defined properties assigned for the product.
		///
		public class ProductSupplierInfo
		{
			///
			///The distributor part number associated with this product, defined by the product distributor.
			///
			public string DistPartNumber { get; set; }

			///
			///The manufacturer part number associated with this product, defined by the product manufacturer.
			///
			public string MfgPartNumber { get; set; }

			///
			///The amount the client pays the supplier to stock this product in its catalogs.
			///
			public ProductCost Cost { get; set; }

		}

}