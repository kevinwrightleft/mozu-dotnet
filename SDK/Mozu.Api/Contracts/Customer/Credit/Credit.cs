
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

namespace Mozu.Api.Contracts.Customer.Credit
{
		///
		///	Properties of the store credit of gift card applied to a customer account. At this time, gift card functionality is reserved for future use.
		///
		public class Credit
		{
			///
			///The date and time the store credit or gift card was activated by the shopper. Credits cannot be used until activated. After the credit is activated, this property value is read-only.
			///
			public DateTime? ActivationDate { get; set; }

			///
			///User-defined identifier of the credit, which is unique within the tenant.
			///
			public string Code { get; set; }

			///
			///The type of customer credit, which is "GiftCard" or "StoreCredit".
			///
			public string CreditType { get; set; }

			///
			///3-letter ISO 4217 standard global currency code. Currently, only "USD" (US Dollar) is supported.
			///
			public string CurrencyCode { get; set; }

			///
			///The current remaining balance of the credit applied to the customer account.
			///
			public decimal CurrentBalance { get; set; }

			///
			///Unique identifier of the shopper associated with the applied credit. For gift cards, this property is not required.
			///
			public int? CustomerId { get; set; }

			///
			///The date and time the credit expires and can no longer be redeemed.
			///
			public DateTime? ExpirationDate { get; set; }

			///
			///The initial balance of the credit applied to the customer account. This value cannot be changed after it is set.
			///
			public decimal InitialBalance { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

		}

}