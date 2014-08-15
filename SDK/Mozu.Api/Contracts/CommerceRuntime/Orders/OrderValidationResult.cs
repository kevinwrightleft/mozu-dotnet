
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


namespace Mozu.Api.Contracts.CommerceRuntime.Orders
{
		///
		///	Properties of the resulting order validation performed by an order validation capability.
		///
		public class OrderValidationResult
		{
			///
			///Date and time when the entity was created, represented in UTC Date/Time.
			///
			public DateTime? CreatedDate { get; set; }

			///
			///The status returned from the order validation capability for the order specified in the request, which is Pass, Fail, Error, or Review.
			///
			public string Status { get; set; }

			///
			///Read-only identifier defined by the order validation capability that uniquely identifies this validation operation.
			///
			public string ValidationId { get; set; }

			///
			///Read-only name of this order validator supplied by the capability.
			///
			public string ValidatorName { get; set; }

			///
			///The type of order validator supplied by the capability. At this time, the only supported validator type is Fraud.
			///
			public string ValidatorType { get; set; }

			///
			///Collection of messages returned by the order validation capability.
			///
			public List<OrderValidationMessage> Messages { get; set; }

		}

}