
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

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.ShippingRuntime
{
		///
		///	Properties required to request a shipping rate calculation.
		///
		public class RateRequest
		{
			public List<string> CarrierIds { get; set; }

			public DateTime? EstimatedShipmentDate { get; set; }

			public bool? IsDestinationAddressCommercial { get; set; }

			public string IsoCurrencyCode { get; set; }

			public decimal? OrderTotal { get; set; }

			public List<string> ShippingServiceTypes { get; set; }

			public List<CustomAttribute> CustomAttributes { get; set; }

			public Address DestinationAddress { get; set; }

			public List<RateRequestItem> Items { get; set; }

			public Address OriginAddress { get; set; }

		}

}