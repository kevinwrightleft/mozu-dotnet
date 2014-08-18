
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


namespace Mozu.Api.Clients.Commerce.Customer.Attributedefinition
{
	/// <summary>
	/// 
	/// </summary>
	public partial class AttributeClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Core.Extensible.AttributeCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAttributes();
		///   var attributeCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Core.Extensible.AttributeCollection> GetAttributesClient()
		{
			return GetAttributesClient( null,  null,  null,  null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Core.Extensible.AttributeCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAttributes( startIndex,  pageSize,  sortBy,  filter);
		///   var attributeCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Core.Extensible.AttributeCollection> GetAttributesClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Attributedefinition.AttributeUrl.GetAttributesUrl(filter, pageSize, sortBy, startIndex);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Core.Extensible.AttributeCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Core.Extensible.Attribute"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAttribute( attributeFQN);
		///   var attributeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Core.Extensible.Attribute> GetAttributeClient(string attributeFQN)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Attributedefinition.AttributeUrl.GetAttributeUrl(attributeFQN);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Core.Extensible.Attribute>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.Core.Extensible.AttributeVocabularyValue"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAttributeVocabularyValues( attributeFQN);
		///   var attributeVocabularyValueClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.Core.Extensible.AttributeVocabularyValue>> GetAttributeVocabularyValuesClient(string attributeFQN)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Attributedefinition.AttributeUrl.GetAttributeVocabularyValuesUrl(attributeFQN);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.Core.Extensible.AttributeVocabularyValue>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}

