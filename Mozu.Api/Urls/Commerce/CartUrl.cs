
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

namespace Mozu.Api.Urls.Commerce
{
	public partial class CartUrl 
	{

		/// <summary>
        /// Get Resource Url for GetCart
        /// </summary>
        /// <param name="cartId">Identifier of the cart to retrieve.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetCartUrl(string cartId)
		{
			var url = "/api/commerce/carts/{cartId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "cartId", cartId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetOrCreateCart
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetOrCreateCartUrl()
		{
			var url = "/api/commerce/carts/current";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetCartSummary
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetCartSummaryUrl()
		{
			var url = "/api/commerce/carts/summary";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetUserCart
        /// </summary>
        /// <param name="userId">Unique identifier of the user whose cart you want to retrieve.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetUserCartUrl(string userId)
		{
			var url = "/api/commerce/carts/user/{userId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "userId", userId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetUserCartSummary
        /// </summary>
        /// <param name="userId">Unique identifier of the user whose cart details you want to retrieve.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetUserCartSummaryUrl(string userId)
		{
			var url = "/api/commerce/carts/user/{userId}/summary";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "userId", userId);
			return mozuUrl;
		}

						/// <summary>
        /// Get Resource Url for UpdateCart
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateCartUrl()
		{
			var url = "/api/commerce/carts/current";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteCart
        /// </summary>
        /// <param name="cartId">Identifier of the cart to delete.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteCartUrl(string cartId)
		{
			var url = "/api/commerce/carts/{cartId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "cartId", cartId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for DeleteCurrentCart
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteCurrentCartUrl()
		{
			var url = "/api/commerce/carts/current";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

		
	}
}
