
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

namespace Mozu.Api.Resources.Content.Documentlists
{
	/// <summary>
	/// Use this subresource to manage documents in a document list.
	/// </summary>
	public partial class DocumentResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		private readonly DataViewMode _dataViewMode;
		
		public DocumentResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
			_dataViewMode = DataViewMode.Live;
		}

		public DocumentResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new DocumentResource(_apiContext.CloneWith(contextModification), _dataViewMode);
		}

		public DocumentResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				
		/// <summary>
		/// Retrieve the content associated with a document, such as a product image or PDF specifications file, by supplying the document ID.
		/// </summary>
		/// <param name="documentId">Unique identifier of the document.</param>
		/// <param name="documentListName">The name of the document list associated with the document.</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var document = new Document();
		///   var stream = document.GetDocumentContent(_dataViewMode,  documentListName,  documentId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual System.IO.Stream GetDocumentContent(string documentListName, string documentId)
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.GetDocumentContentClient(_dataViewMode,  documentListName,  documentId);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<System.IO.Stream> GetDocumentContentAsync(string documentListName, string documentId)
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.GetDocumentContentClient(_dataViewMode,  documentListName,  documentId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves a specific document within the specified document list by providing the document ID.
		/// </summary>
		/// <param name="documentId">Identifier of the document being retrieved.</param>
		/// <param name="documentListName">The name of the document list associated with the document to retrieve.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.Document"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var document = new Document();
		///   var document = document.GetDocument(_dataViewMode,  documentListName,  documentId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Content.Document GetDocument(string documentListName, string documentId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.Document> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.GetDocumentClient(_dataViewMode,  documentListName,  documentId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Content.Document> GetDocumentAsync(string documentListName, string documentId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.Document> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.GetDocumentClient(_dataViewMode,  documentListName,  documentId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves a collection of documents according to any filter and sort criteria.
		/// </summary>
		/// <param name="documentListName">The name of the document list.</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. You can filter a document's search results by any of its properties, including its name or folder path. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=Name+sw+Events"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.DocumentCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var document = new Document();
		///   var documentCollection = document.GetDocuments(_dataViewMode,  documentListName,  filter,  sortBy,  pageSize,  startIndex,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Content.DocumentCollection GetDocuments(string documentListName, string filter =  null, string sortBy =  null, int? pageSize =  null, int? startIndex =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentCollection> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.GetDocumentsClient(_dataViewMode,  documentListName,  filter,  sortBy,  pageSize,  startIndex,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Content.DocumentCollection> GetDocumentsAsync(string documentListName, string filter =  null, string sortBy =  null, int? pageSize =  null, int? startIndex =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentCollection> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.GetDocumentsClient(_dataViewMode,  documentListName,  filter,  sortBy,  pageSize,  startIndex,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates a new document in an existing list.
		/// </summary>
		/// <param name="documentListName">The descriptive alphanumeric document list name being created.</param>
		/// <param name="responseFields"></param>
		/// <param name="document">The descriptive name of the newly created document.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.Document"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var document = new Document();
		///   var document = document.CreateDocument(_dataViewMode,  document,  documentListName,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Content.Document CreateDocument(Mozu.Api.Contracts.Content.Document document, string documentListName, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.Document> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.CreateDocumentClient(_dataViewMode,  document,  documentListName,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Content.Document> CreateDocumentAsync(Mozu.Api.Contracts.Content.Document document, string documentListName, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.Document> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.CreateDocumentClient(_dataViewMode,  document,  documentListName,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates the content associated with a document, such as a product image or PDF specifications file, by supplying the document ID.
		/// </summary>
		/// <param name="documentId">Unique identifier of the document.</param>
		/// <param name="documentListName">The name of the document list associated with the document.</param>
		/// <param name="stream"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var document = new Document();
		///   document.UpdateDocumentContent( stream,  documentListName,  documentId,  contentType);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void UpdateDocumentContent(System.IO.Stream stream, string documentListName, string documentId, String  contentType= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.UpdateDocumentContentClient( stream,  documentListName,  documentId,  contentType);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		public virtual async Task UpdateDocumentContentAsync(System.IO.Stream stream, string documentListName, string documentId, String  contentType= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.UpdateDocumentContentClient( stream,  documentListName,  documentId,  contentType);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// Updates a document in a document list.
		/// </summary>
		/// <param name="documentId">Unique identifier of the document to update.</param>
		/// <param name="documentListName">Name of the document list associated with the document.</param>
		/// <param name="responseFields"></param>
		/// <param name="document">Properties of the document to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.Document"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var document = new Document();
		///   var document = document.UpdateDocument( document,  documentListName,  documentId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Content.Document UpdateDocument(Mozu.Api.Contracts.Content.Document document, string documentListName, string documentId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.Document> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.UpdateDocumentClient( document,  documentListName,  documentId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Content.Document> UpdateDocumentAsync(Mozu.Api.Contracts.Content.Document document, string documentListName, string documentId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.Document> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.UpdateDocumentClient( document,  documentListName,  documentId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes a specific document based on the specified document ID.
		/// </summary>
		/// <param name="documentId">Identifier of the document being deleted.</param>
		/// <param name="documentListName">The name of the document list associated with the document list being deleted.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var document = new Document();
		///   document.DeleteDocument( documentListName,  documentId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteDocument(string documentListName, string documentId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.DeleteDocumentClient( documentListName,  documentId);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		public virtual async Task DeleteDocumentAsync(string documentListName, string documentId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.DeleteDocumentClient( documentListName,  documentId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// Deletes the content associated with a document, such as a product image or PDF specification, by supplying the document ID.
		/// </summary>
		/// <param name="documentId">Unique identifier of the document.</param>
		/// <param name="documentListName">The name of the document list associated with the document.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var document = new Document();
		///   document.DeleteDocumentContent( documentListName,  documentId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteDocumentContent(string documentListName, string documentId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.DeleteDocumentContentClient( documentListName,  documentId);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		public virtual async Task DeleteDocumentContentAsync(string documentListName, string documentId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.DeleteDocumentContentClient( documentListName,  documentId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


