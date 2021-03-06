
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

namespace Mozu.Api.Urls.Platform.Entitylists
{
	public partial class EntityUrl 
	{

		/// <summary>
        /// Get Resource Url for GetEntity
        /// </summary>
        /// <param name="entityListFullName"></param>
        /// <param name="id"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetEntityUrl(string entityListFullName, string id, string responseFields =  null)
		{
			var url = "/api/platform/entitylists/{entityListFullName}/entities/{id}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "entityListFullName", entityListFullName);
			mozuUrl.FormatUrl( "id", id);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetEntities
        /// </summary>
        /// <param name="entityListFullName"></param>
        /// <param name="filter"></param>
        /// <param name="pageSize"></param>
        /// <param name="responseFields"></param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetEntitiesUrl(string entityListFullName, int? pageSize =  null, int? startIndex =  null, string filter =  null, string sortBy =  null, string responseFields =  null)
		{
			var url = "/api/platform/entitylists/{entityListFullName}/entities?pageSize={pageSize}&startIndex={startIndex}&filter={filter}&sortBy={sortBy}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "entityListFullName", entityListFullName);
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for InsertEntity
        /// </summary>
        /// <param name="entityListFullName"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl InsertEntityUrl(string entityListFullName, string responseFields =  null)
		{
			var url = "/api/platform/entitylists/{entityListFullName}/entities/?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "entityListFullName", entityListFullName);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateEntity
        /// </summary>
        /// <param name="entityListFullName"></param>
        /// <param name="id"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateEntityUrl(string entityListFullName, string id, string responseFields =  null)
		{
			var url = "/api/platform/entitylists/{entityListFullName}/entities/{id}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "entityListFullName", entityListFullName);
			mozuUrl.FormatUrl( "id", id);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteEntity
        /// </summary>
        /// <param name="entityListFullName"></param>
        /// <param name="id"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteEntityUrl(string entityListFullName, string id)
		{
			var url = "/api/platform/entitylists/{entityListFullName}/entities/{id}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "entityListFullName", entityListFullName);
			mozuUrl.FormatUrl( "id", id);
			return mozuUrl;
		}

		
	}
}

