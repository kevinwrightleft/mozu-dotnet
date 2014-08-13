
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
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Mozu.Api.Clients.Content
{
	/// <summary>
	/// Use the document lists resource to organize your site's documents into a hierarchy. Document lists can contain documents, folders, and complete hierarchies of folders, which contain documents with unique names.
	/// </summary>
	public partial class DocumentListClient 	{
		
		/// <summary>
		/// Retrieves a collection of document lists.
		/// </summary>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.DocumentListCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDocumentLists(dataViewMode,  pageSize,  startIndex,  responseFields);
		///   var documentListCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.DocumentListCollection> GetDocumentListsClient(DataViewMode dataViewMode, int? pageSize =  null, int? startIndex =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Content.DocumentListUrl.GetDocumentListsUrl(pageSize, startIndex, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.DocumentListCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieve the details of a document list by providing the list name.
		/// </summary>
		/// <param name="documentListName">The name of the document list.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.DocumentList"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDocumentList(dataViewMode,  documentListName,  responseFields);
		///   var documentListClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.DocumentList> GetDocumentListClient(DataViewMode dataViewMode, string documentListName, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Content.DocumentListUrl.GetDocumentListUrl(documentListName, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.DocumentList>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="list"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.DocumentList"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateDocumentList( list,  responseFields);
		///   var documentListClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.DocumentList> CreateDocumentListClient(Mozu.Api.Contracts.Content.DocumentList list, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Content.DocumentListUrl.CreateDocumentListUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.DocumentList>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Content.DocumentList>(list);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="documentListName"></param>
		/// <param name="responseFields"></param>
		/// <param name="list"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.DocumentList"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateDocumentList( list,  documentListName,  responseFields);
		///   var documentListClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.DocumentList> UpdateDocumentListClient(Mozu.Api.Contracts.Content.DocumentList list, string documentListName, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Content.DocumentListUrl.UpdateDocumentListUrl(documentListName, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.DocumentList>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Content.DocumentList>(list);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="documentListName"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteDocumentList( documentListName);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteDocumentListClient(string documentListName)
		{
			var url = Mozu.Api.Urls.Content.DocumentListUrl.DeleteDocumentListUrl(documentListName);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


