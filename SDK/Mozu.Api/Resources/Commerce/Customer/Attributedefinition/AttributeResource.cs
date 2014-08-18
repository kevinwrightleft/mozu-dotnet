
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

namespace Mozu.Api.Resources.Commerce.Customer.Attributedefinition
{
	/// <summary>
	/// 
	/// </summary>
	public partial class AttributeResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public AttributeResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}
				
		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.Extensible.AttributeCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attribute = new Attribute();
		///   var attributeCollection = attribute.GetAttributes( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Core.Extensible.AttributeCollection GetAttributes(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Core.Extensible.AttributeCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Attributedefinition.AttributeClient.GetAttributesClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Core.Extensible.AttributeCollection> GetAttributesAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Core.Extensible.AttributeCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Attributedefinition.AttributeClient.GetAttributesClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.Core.Extensible.AttributeVocabularyValue"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var attribute = new Attribute();
		///   var attributeVocabularyValue = attribute.GetAttributeVocabularyValues( attributeFQN);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.Core.Extensible.AttributeVocabularyValue> GetAttributeVocabularyValues(string attributeFQN)
		{
			MozuClient<List<Mozu.Api.Contracts.Core.Extensible.AttributeVocabularyValue>> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Attributedefinition.AttributeClient.GetAttributeVocabularyValuesClient( attributeFQN);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<List<Mozu.Api.Contracts.Core.Extensible.AttributeVocabularyValue>> GetAttributeVocabularyValuesAsync(string attributeFQN)
		{
			MozuClient<List<Mozu.Api.Contracts.Core.Extensible.AttributeVocabularyValue>> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Attributedefinition.AttributeClient.GetAttributeVocabularyValuesClient( attributeFQN);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.Extensible.Attribute"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attribute = new Attribute();
		///   var attribute = attribute.GetAttribute( attributeFQN,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Core.Extensible.Attribute GetAttribute(string attributeFQN, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Core.Extensible.Attribute> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Attributedefinition.AttributeClient.GetAttributeClient( attributeFQN,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Core.Extensible.Attribute> GetAttributeAsync(string attributeFQN, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Core.Extensible.Attribute> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Attributedefinition.AttributeClient.GetAttributeClient( attributeFQN,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}

