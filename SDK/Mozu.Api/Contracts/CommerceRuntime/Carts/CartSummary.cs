
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.CommerceRuntime.Carts
{
		///
		///	The properties of an active shopping cart.
		///
		public class CartSummary
		{
			///
			///If true, this shopping cart is active.
			///
			public bool? HasActiveCart { get; set; }

			///
			///If true, the cart's period of inactivity is past its calculated expiration date and the cart is considered abandoned.
			///
			public bool? IsExpired { get; set; }

			///
			///The total number of line items in the cart. Each line item can have multiple quantities.
			///
			public int? ItemCount { get; set; }

			///
			///Estimated total amount of the cart, including items, sales tax, shipping costs, and other fees.
			///
			public decimal? Total { get; set; }

			public int? TotalQuantity { get; set; }

		}

}