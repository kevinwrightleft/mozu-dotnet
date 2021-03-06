
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
using Mozu.Api.Contracts.CommerceRuntime.Commerce;

namespace Mozu.Api.Contracts.CommerceRuntime.Fulfillment
{
		///
		///	Properties of a physical package shipped for an order.
		///
		public class Package
		{
			///
			///The actions that a user can perform for a package at this time.
			///
			public List<string> AvailableActions { get; set; }

			public string Code { get; set; }

			///
			///The date and time the package shipped to the customer.
			///
			public DateTime? FulfillmentDate { get; set; }

			public string FulfillmentLocationCode { get; set; }

			public bool HasLabel { get; set; }

			///
			///Unique identifier of a package.
			///
			public string Id { get; set; }

			///
			///The package type associated with this physical package. Possible values include Tube, Letter, Pak, Small Box (carrier_box_small), Medium Box (carrier_box_medium), Large Box (carrier_box_large), or Custom.
			///
			public string PackagingType { get; set; }

			///
			///Unique identifier of the shipment associated with this package.
			///
			public string ShipmentId { get; set; }

			///
			///The code associated with the carrier's shipping method service type. Service type codes include a prefix that indicates the carrier. For example: FEDEX_INTERNATIONAL_STANDARD
			///
			public string ShippingMethodCode { get; set; }

			///
			///Name of the shipping method associated with the package. For example: UPS Ground or 2nd Day Air.
			///
			public string ShippingMethodName { get; set; }

			///
			///Status of the package, which is "Fulfilled" or "NotFulfilled".
			///
			public string Status { get; set; }

			///
			///Tracking number for the package supplied by the carrier.
			///
			public string TrackingNumber { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			public List<ChangeMessage> ChangeMessages { get; set; }

			///
			///An array list of objects in the returned collection.
			///
			public List<PackageItem> Items { get; set; }

			///
			///Dimensional properties of the package.
			///
			public PackageMeasurements Measurements { get; set; }

		}

}