
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
		///
		///	Properties of an item for which to calculate a shipping rate.
		///
		public class RateRequestItem
		{
			///
			///Unique identifier of the item to ship, for which to calculate a shipping rate.
			///
			public string ItemId { get; set; }

			///
			///Quantity of the item for which to calculate the shipping rate.
			///
			public int? Quantity { get; set; }

			///
			///If true, this item must ship separately from other items in a shipment.
			///
			public bool? ShipsByItself { get; set; }

			public List<ProductSummary> ProductSummaries { get; set; }

			///
			///The measured weight and dimensions of the item to ship.
			///
			public ItemMeasurements UnitMeasurements { get; set; }

		}

}