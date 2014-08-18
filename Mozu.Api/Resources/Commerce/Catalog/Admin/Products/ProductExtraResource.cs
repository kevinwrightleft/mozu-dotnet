
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


namespace Mozu.Api.Resources.Commerce.Catalog.Admin.Products
{
	/// <summary>
	/// Use the Extras resource to configure an extra product attribute for products associated with the product type that uses the extra attribute.
	/// </summary>
	public partial class ProductExtraResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		public ProductExtraResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves a list of extras configured for the product according to any defined filter and sort criteria.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductExtra"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var productextra = new ProductExtra();
		///   var productExtra = productextra.GetExtras(dataViewMode,  productCode);
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.ProductAdmin.ProductExtra> GetExtras(DataViewMode dataViewMode, string productCode)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductExtra>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductExtraClient.GetExtrasClient(dataViewMode,  productCode);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of an extra attribute configuration for the product specified in the request.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductExtra"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productextra = new ProductExtra();
		///   var productExtra = productextra.GetExtra(dataViewMode,  productCode,  attributeFQN);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductExtra GetExtra(DataViewMode dataViewMode, string productCode, string attributeFQN)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductExtra> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductExtraClient.GetExtraClient(dataViewMode,  productCode,  attributeFQN);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Configure an extra attribute for the product specified in the request.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="productExtra">Properties of the product extra to configure for the specified product.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductExtra"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productextra = new ProductExtra();
		///   var productExtra = productextra.AddExtra(dataViewMode,  productExtra,  productCode);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductExtra AddExtra(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductExtra productExtra, string productCode)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductExtra> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductExtraClient.AddExtraClient(dataViewMode,  productExtra,  productCode);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates the configuration of an extra attribute for the product specified in the request.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="productExtra">Properties of the extra attribute to update for the specified product.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductExtra"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productextra = new ProductExtra();
		///   var productExtra = productextra.UpdateExtra(dataViewMode,  productExtra,  productCode,  attributeFQN);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductExtra UpdateExtra(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductExtra productExtra, string productCode, string attributeFQN)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductExtra> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductExtraClient.UpdateExtraClient(dataViewMode,  productExtra,  productCode,  attributeFQN);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Delete a product extra configuration for the product specified in the request.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var productextra = new ProductExtra();
		///   productextra.DeleteExtra(dataViewMode,  productCode,  attributeFQN);
		/// </code>
		/// </example>
		public virtual void DeleteExtra(DataViewMode dataViewMode, string productCode, string attributeFQN)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductExtraClient.DeleteExtraClient(dataViewMode,  productCode,  attributeFQN);
			client.WithContext(_apiContext);
			response= client.Execute();

		}


	}

}

