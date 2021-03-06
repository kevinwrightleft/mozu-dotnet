
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Discount used to calculate SalePrice. Includes coupon code if applicable, amount of the discount, and discount savings. Discounts can be either an absolute price or a percentage off. The sale price beats any discounts.
		///
		public class Discount
		{
			///
			///The integer amount of the discount. For example, an entry of "10" could represent a discount of $10.00 or a discount of 10%, depending on the type.
			///
			public decimal? Amount { get; set; }

			///
			///The type of discount amount, such as an amount or a percentage.
			///
			public string AmountType { get; set; }

			///
			///The most recent number of redeemed discounts.
			///
			public int? CurrentRedemptionCount { get; set; }

			public bool? DoesNotApplyToSalePrice { get; set; }

			///
			///Unique identifier of the discount.
			///
			public int? Id { get; set; }

			public int? MaximumUsesPerUser { get; set; }

			///
			///The scope to which the discount applies, which is "Order" for order discounts or "LineItem" for individual product discounts.
			///
			public string Scope { get; set; }

			///
			///Current status of the product discount. Possible values are "Active", "Scheduled", or "Expired".
			///
			public string Status { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			public DiscountCondition Conditions { get; set; }

			///
			///Complex type that contains content for a language specified by LocaleCode.
			///
			public DiscountLocalizedContent Content { get; set; }

			///
			///Properties of the target object to which the discount applies, such as a product or an order.
			///
			public DiscountTarget Target { get; set; }

		}

}