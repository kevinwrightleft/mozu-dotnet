
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.CommerceRuntime.Products
{
		///
		///	The price of a product that appears on a storefront after any applied discounts.
		///
		public class ProductPrice
		{
			public decimal? CreditValue { get; set; }

			public decimal? Msrp { get; set; }

			///
			///The price the merchant charges for a product on a storefront if no sales price is defined.
			///
			public decimal? Price { get; set; }

			///
			///Current sale price defined for a product on a storefront.
			///
			public decimal? SalePrice { get; set; }

			///
			///The override price defined by the tenant for this cart or order item.
			///
			public decimal? TenantOverridePrice { get; set; }

		}

}