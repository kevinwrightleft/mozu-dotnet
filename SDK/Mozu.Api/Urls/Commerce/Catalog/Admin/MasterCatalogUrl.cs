
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce.Catalog.Admin
{
	public partial class MasterCatalogUrl 
	{

		/// <summary>
        /// Get Resource Url for GetMasterCatalogs
        /// </summary>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetMasterCatalogsUrl(string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/mastercatalogs/?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetMasterCatalog
        /// </summary>
        /// <param name="masterCatalogId"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetMasterCatalogUrl(int masterCatalogId, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/mastercatalogs/{masterCatalogId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "masterCatalogId", masterCatalogId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

						/// <summary>
        /// Get Resource Url for UpdateMasterCatalog
        /// </summary>
        /// <param name="masterCatalogId"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateMasterCatalogUrl(int masterCatalogId, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/mastercatalogs/{masterCatalogId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "masterCatalogId", masterCatalogId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				
	}
}

