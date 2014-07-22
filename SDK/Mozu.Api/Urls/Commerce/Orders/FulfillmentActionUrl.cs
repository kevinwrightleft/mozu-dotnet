
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

namespace Mozu.Api.Urls.Commerce.Orders
{
	public partial class FulfillmentActionUrl 
	{

				/// <summary>
        /// Get Resource Url for PerformFulfillmentAction
        /// </summary>
        /// <param name="orderId">Unique identifier of the order for which to perform the fulfillment action.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl PerformFulfillmentActionUrl(string orderId)
		{
			var url = "/api/commerce/orders/{orderId}/fulfillment/actions/";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			return mozuUrl;
		}

						
	}
}
