
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
using Mozu.Api.Security;


namespace Mozu.Api.Resources.Commerce.Returns
{
	/// <summary>
	/// Use the return shipments subresource to manage shipments for a return replacement.
	/// </summary>
	public partial class ShipmentResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		public ShipmentResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves the details of the specified return replacement shipment.
		/// </summary>
		/// <param name="returnId">Unique identifier of the return associated with the replacement shipment to retrieve.</param>
		/// <param name="shipmentId">Unique identifier of the return replacement shipment to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Shipment"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var shipment = new Shipment();
		///   var shipment = shipment.GetShipment( returnId,  shipmentId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Shipment GetShipment(string returnId, string shipmentId)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Shipment> response;
			var client = Mozu.Api.Clients.Commerce.Returns.ShipmentClient.GetShipmentClient( returnId,  shipmentId);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Creates a shipment from one or more packages associated with a return replacement.
		/// </summary>
		/// <param name="returnId">Unique identifier of the return for which to create replacement package shipments.</param>
		/// <param name="packageIds">List of packages in the return replacement shipment.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var shipment = new Shipment();
		///   var package = shipment.CreatePackageShipments( packageIds,  returnId);
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package> CreatePackageShipments(List<string> packageIds, string returnId)
		{
			MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>> response;
			var client = Mozu.Api.Clients.Commerce.Returns.ShipmentClient.CreatePackageShipmentsClient( packageIds,  returnId);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Deletes a shipment for a return replacement.
		/// </summary>
		/// <param name="returnId">Unique identifier of the return associated with the replacement shipment to delete.</param>
		/// <param name="shipmentId">Unique identifier of the return replacement shipment to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var shipment = new Shipment();
		///   shipment.DeleteShipment( returnId,  shipmentId);
		/// </code>
		/// </example>
		public virtual void DeleteShipment(string returnId, string shipmentId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Returns.ShipmentClient.DeleteShipmentClient( returnId,  shipmentId);
			client.WithContext(_apiContext);
			response= client.Execute();

		}


	}

}

