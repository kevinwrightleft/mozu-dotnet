
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	Properties of a defined product discount.
		///
		public class Discount
		{
			///
			///Unique identifier of the discount. System-supplied and read only.
			///
			public int DiscountId { get; set; }

			///
			///The date and time when the product discount will no longer be active. Date in UTC Date/Time. System-supplied and read-only.
			///
			public DateTime? ExpirationDate { get; set; }

			public string FriendlyDescription { get; set; }

			///
			///The name assigned for the product discount.
			///
			public string Name { get; set; }

		}

}