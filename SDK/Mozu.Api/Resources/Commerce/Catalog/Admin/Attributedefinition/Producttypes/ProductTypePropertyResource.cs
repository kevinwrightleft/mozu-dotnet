
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

namespace Mozu.Api.Resources.Commerce.Catalog.Admin.Attributedefinition.Producttypes
{
	/// <summary>
	/// Use the Properties subresource to define how property product attributes are used for a specific product type. Product attribute definitions are unique for each associated product type.
	/// </summary>
	public partial class ProductTypePropertyResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		private readonly DataViewMode _dataViewMode;
		
		public ProductTypePropertyResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
			_dataViewMode = DataViewMode.Live;
		}
		public ProductTypePropertyResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				
		/// <summary>
		/// Retrieves a list of product property attributes defined for a product type.
		/// </summary>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypeproperty = new ProductTypeProperty();
		///   var attributeInProductType = producttypeproperty.GetProperties(_dataViewMode,  productTypeId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> GetProperties(int productTypeId)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyClient.GetPropertiesClient(_dataViewMode,  productTypeId);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType>> GetPropertiesAsync(int productTypeId)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyClient.GetPropertiesClient(_dataViewMode,  productTypeId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves a product property attribute definition for the specified product type.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="responseFields"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypeproperty = new ProductTypeProperty();
		///   var attributeInProductType = producttypeproperty.GetProperty(_dataViewMode,  productTypeId,  attributeFQN,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.AttributeInProductType GetProperty(int productTypeId, string attributeFQN, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyClient.GetPropertyClient(_dataViewMode,  productTypeId,  attributeFQN,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> GetPropertyAsync(int productTypeId, string attributeFQN, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyClient.GetPropertyClient(_dataViewMode,  productTypeId,  attributeFQN,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Assigns a property attribute to the specified product type, according to the information defined in the request.
		/// </summary>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="responseFields"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="attributeInProductType">Properties of the property attribute to define for the specified product type.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypeproperty = new ProductTypeProperty();
		///   var attributeInProductType = producttypeproperty.AddProperty( attributeInProductType,  productTypeId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.AttributeInProductType AddProperty(Mozu.Api.Contracts.ProductAdmin.AttributeInProductType attributeInProductType, int productTypeId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyClient.AddPropertyClient( attributeInProductType,  productTypeId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> AddPropertyAsync(Mozu.Api.Contracts.ProductAdmin.AttributeInProductType attributeInProductType, int productTypeId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyClient.AddPropertyClient( attributeInProductType,  productTypeId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates the definition of a property attribute for the specified product type.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="responseFields"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="attributeInProductType">Properties of the property attribute to define for the product type.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypeproperty = new ProductTypeProperty();
		///   var attributeInProductType = producttypeproperty.UpdateProperty( attributeInProductType,  productTypeId,  attributeFQN,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.AttributeInProductType UpdateProperty(Mozu.Api.Contracts.ProductAdmin.AttributeInProductType attributeInProductType, int productTypeId, string attributeFQN, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyClient.UpdatePropertyClient( attributeInProductType,  productTypeId,  attributeFQN,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> UpdatePropertyAsync(Mozu.Api.Contracts.ProductAdmin.AttributeInProductType attributeInProductType, int productTypeId, string attributeFQN, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyClient.UpdatePropertyClient( attributeInProductType,  productTypeId,  attributeFQN,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Removes a property attribute previously defined for the specified product type.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypeproperty = new ProductTypeProperty();
		///   producttypeproperty.DeleteProperty( productTypeId,  attributeFQN);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteProperty(int productTypeId, string attributeFQN)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyClient.DeletePropertyClient( productTypeId,  attributeFQN);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		public virtual async Task DeletePropertyAsync(int productTypeId, string attributeFQN)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyClient.DeletePropertyClient( productTypeId,  attributeFQN);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


