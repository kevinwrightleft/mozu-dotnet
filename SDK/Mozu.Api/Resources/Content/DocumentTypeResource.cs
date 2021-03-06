
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

namespace Mozu.Api.Resources.Content
{
	/// <summary>
	/// The DocumentTypes resource is a part of the Content Service.
	/// </summary>
	public partial class DocumentTypeResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		private readonly DataViewMode _dataViewMode;
		
		public DocumentTypeResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
			_dataViewMode = DataViewMode.Live;
		}

		public DocumentTypeResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new DocumentTypeResource(_apiContext.CloneWith(contextModification), _dataViewMode);
		}

		public DocumentTypeResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				
		/// <summary>
		/// 
		/// </summary>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.DocumentTypeCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttype = new DocumentType();
		///   var documentTypeCollection = documenttype.GetDocumentTypes(_dataViewMode,  pageSize,  startIndex,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Content.DocumentTypeCollection GetDocumentTypes(int? pageSize =  null, int? startIndex =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentTypeCollection> response;
			var client = Mozu.Api.Clients.Content.DocumentTypeClient.GetDocumentTypesClient(_dataViewMode,  pageSize,  startIndex,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Content.DocumentTypeCollection> GetDocumentTypesAsync(int? pageSize =  null, int? startIndex =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentTypeCollection> response;
			var client = Mozu.Api.Clients.Content.DocumentTypeClient.GetDocumentTypesClient(_dataViewMode,  pageSize,  startIndex,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="documentTypeName"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.DocumentType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttype = new DocumentType();
		///   var documentType = documenttype.GetDocumentType(_dataViewMode,  documentTypeName,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Content.DocumentType GetDocumentType(string documentTypeName, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentType> response;
			var client = Mozu.Api.Clients.Content.DocumentTypeClient.GetDocumentTypeClient(_dataViewMode,  documentTypeName,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Content.DocumentType> GetDocumentTypeAsync(string documentTypeName, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentType> response;
			var client = Mozu.Api.Clients.Content.DocumentTypeClient.GetDocumentTypeClient(_dataViewMode,  documentTypeName,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="documentType"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.DocumentType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttype = new DocumentType();
		///   var documentType = documenttype.CreateDocumentType(_dataViewMode,  documentType,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Content.DocumentType CreateDocumentType(Mozu.Api.Contracts.Content.DocumentType documentType, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentType> response;
			var client = Mozu.Api.Clients.Content.DocumentTypeClient.CreateDocumentTypeClient(_dataViewMode,  documentType,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Content.DocumentType> CreateDocumentTypeAsync(Mozu.Api.Contracts.Content.DocumentType documentType, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentType> response;
			var client = Mozu.Api.Clients.Content.DocumentTypeClient.CreateDocumentTypeClient(_dataViewMode,  documentType,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="documentTypeName"></param>
		/// <param name="responseFields"></param>
		/// <param name="documentType"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.DocumentType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttype = new DocumentType();
		///   var documentType = documenttype.UpdateDocumentType( documentType,  documentTypeName,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Content.DocumentType UpdateDocumentType(Mozu.Api.Contracts.Content.DocumentType documentType, string documentTypeName, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentType> response;
			var client = Mozu.Api.Clients.Content.DocumentTypeClient.UpdateDocumentTypeClient( documentType,  documentTypeName,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Content.DocumentType> UpdateDocumentTypeAsync(Mozu.Api.Contracts.Content.DocumentType documentType, string documentTypeName, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentType> response;
			var client = Mozu.Api.Clients.Content.DocumentTypeClient.UpdateDocumentTypeClient( documentType,  documentTypeName,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


