
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

namespace Mozu.Api.Urls.Platform
{
	public partial class EntityListUrl 
	{

		/// <summary>
        /// Get Resource Url for GetEntityLists
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="pageSize"></param>
        /// <param name="responseFields"></param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetEntityListsUrl(int? pageSize =  null, int? startIndex =  null, string filter =  null, string sortBy =  null, string responseFields =  null)
		{
			var url = "/api/platform/entitylists/?pageSize={pageSize}&startIndex={startIndex}&filter={filter}&sortBy={sortBy}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetEntityList
        /// </summary>
        /// <param name="entityListFullName"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetEntityListUrl(string entityListFullName, string responseFields =  null)
		{
			var url = "/api/platform/entitylists/{entityListFullName}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "entityListFullName", entityListFullName);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreateEntityList
        /// </summary>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateEntityListUrl(string responseFields =  null)
		{
			var url = "/api/platform/entitylists/?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateEntityList
        /// </summary>
        /// <param name="entityListFullName"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateEntityListUrl(string entityListFullName, string responseFields =  null)
		{
			var url = "/api/platform/entitylists/{entityListFullName}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "entityListFullName", entityListFullName);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteEntityList
        /// </summary>
        /// <param name="entityListFullName"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteEntityListUrl(string entityListFullName)
		{
			var url = "/api/platform/entitylists/{entityListFullName}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "entityListFullName", entityListFullName);
			return mozuUrl;
		}

		
	}
}

