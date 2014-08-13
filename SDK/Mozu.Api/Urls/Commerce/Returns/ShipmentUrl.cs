
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce.Returns
{
	public partial class ShipmentUrl 
	{

		/// <summary>
        /// Get Resource Url for GetShipment
        /// </summary>
        /// <param name="responseFields"></param>
        /// <param name="returnId">Unique identifier of the return associated with the replacement shipment to retrieve.</param>
        /// <param name="shipmentId">Unique identifier of the return replacement shipment to retrieve.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetShipmentUrl(string returnId, string shipmentId, string responseFields =  null)
		{
			var url = "/api/commerce/returns/{returnId}/shipments/{shipmentId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "returnId", returnId);
			mozuUrl.FormatUrl( "shipmentId", shipmentId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreatePackageShipments
        /// </summary>
        /// <param name="returnId">Unique identifier of the return for which to create replacement package shipments.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreatePackageShipmentsUrl(string returnId)
		{
			var url = "/api/commerce/returns/{returnId}/shipments";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

						/// <summary>
        /// Get Resource Url for DeleteShipment
        /// </summary>
        /// <param name="returnId">Unique identifier of the return associated with the replacement shipment to delete.</param>
        /// <param name="shipmentId">Unique identifier of the return replacement shipment to delete.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteShipmentUrl(string returnId, string shipmentId)
		{
			var url = "/api/commerce/returns/{returnId}/shipments/{shipmentId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "returnId", returnId);
			mozuUrl.FormatUrl( "shipmentId", shipmentId);
			return mozuUrl;
		}

		
	}
}

