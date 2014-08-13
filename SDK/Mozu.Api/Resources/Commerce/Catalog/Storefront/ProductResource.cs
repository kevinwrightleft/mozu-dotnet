
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

namespace Mozu.Api.Resources.Commerce.Catalog.Storefront
{
	/// <summary>
	/// Use the Storefront Products  resource to manage the shopper product selection process during a visit to the web storefront. You can update product options as shoppers pick and choose their product choices. A shopper cannot add a product to a cart until all of its required options have been selected.
	/// </summary>
	public partial class ProductResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public ProductResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}
				
		/// <summary>
		/// Retrieves a list of products that appear on the storefront according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.ProductCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var productCollection = product.GetProducts( filter,  startIndex,  pageSize,  sortBy,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductRuntime.ProductCollection GetProducts(string filter =  null, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.ProductCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductClient.GetProductsClient( filter,  startIndex,  pageSize,  sortBy,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.ProductCollection> GetProductsAsync(string filter =  null, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.ProductCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductClient.GetProductsClient( filter,  startIndex,  pageSize,  sortBy,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the active inventory level information associated with the product or location specified in the request.
		/// </summary>
		/// <param name="locationCodes">Array of location codes for which to retrieve product inventory information.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.LocationInventoryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var locationInventoryCollection = product.GetProductInventory( productCode,  locationCodes,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductRuntime.LocationInventoryCollection GetProductInventory(string productCode, string locationCodes =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.LocationInventoryCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductClient.GetProductInventoryClient( productCode,  locationCodes,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.LocationInventoryCollection> GetProductInventoryAsync(string productCode, string locationCodes =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.LocationInventoryCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductClient.GetProductInventoryClient( productCode,  locationCodes,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves information about a single product given its product code.
		/// </summary>
		/// <param name="allowInactive">If true, returns an inactive product as part of the query.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields"></param>
		/// <param name="skipInventoryCheck">If true, skip the inventory validation process for the specified product.</param>
		/// <param name="variationProductCode">Merchant-created code associated with a specific product variation. Variation product codes maintain an association with the base product code.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.Product"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var product = product.GetProduct( productCode,  variationProductCode,  allowInactive,  skipInventoryCheck,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductRuntime.Product GetProduct(string productCode, string variationProductCode =  null, bool? allowInactive =  null, bool? skipInventoryCheck =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.Product> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductClient.GetProductClient( productCode,  variationProductCode,  allowInactive,  skipInventoryCheck,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.Product> GetProductAsync(string productCode, string variationProductCode =  null, bool? allowInactive =  null, bool? skipInventoryCheck =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.Product> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductClient.GetProductClient( productCode,  variationProductCode,  allowInactive,  skipInventoryCheck,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates a new product configuration each time a shopper selects a product option value. After the shopper defines values for all required product options, the shopper can add the product configuration to a cart.
		/// </summary>
		/// <param name="includeOptionDetails">If true, the response returns details about the product. If false, returns a product summary such as the product name, price, and sale price.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields"></param>
		/// <param name="skipInventoryCheck">If true, skip the inventory validation process for the specified product.</param>
		/// <param name="productOptionSelections">For a product with shopper-configurable options, the properties of the product options selected by the shopper.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.ConfiguredProduct"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var configuredProduct = product.ConfiguredProduct( productOptionSelections,  productCode,  includeOptionDetails,  skipInventoryCheck,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductRuntime.ConfiguredProduct ConfiguredProduct(Mozu.Api.Contracts.ProductRuntime.ProductOptionSelections productOptionSelections, string productCode, bool? includeOptionDetails =  null, bool? skipInventoryCheck =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.ConfiguredProduct> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductClient.ConfiguredProductClient( productOptionSelections,  productCode,  includeOptionDetails,  skipInventoryCheck,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.ConfiguredProduct> ConfiguredProductAsync(Mozu.Api.Contracts.ProductRuntime.ProductOptionSelections productOptionSelections, string productCode, bool? includeOptionDetails =  null, bool? skipInventoryCheck =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.ConfiguredProduct> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductClient.ConfiguredProductClient( productOptionSelections,  productCode,  includeOptionDetails,  skipInventoryCheck,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Validate the final state of shopper-selected options.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields"></param>
		/// <param name="skipInventoryCheck">If true, skip the inventory validation process for the specified product.</param>
		/// <param name="productOptionSelections">For a product with shopper-configurable options, the properties of the product options selected by the shopper.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.ProductValidationSummary"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var productValidationSummary = product.ValidateProduct( productOptionSelections,  productCode,  skipInventoryCheck,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductRuntime.ProductValidationSummary ValidateProduct(Mozu.Api.Contracts.ProductRuntime.ProductOptionSelections productOptionSelections, string productCode, bool? skipInventoryCheck =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.ProductValidationSummary> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductClient.ValidateProductClient( productOptionSelections,  productCode,  skipInventoryCheck,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.ProductValidationSummary> ValidateProductAsync(Mozu.Api.Contracts.ProductRuntime.ProductOptionSelections productOptionSelections, string productCode, bool? skipInventoryCheck =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.ProductValidationSummary> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductClient.ValidateProductClient( productOptionSelections,  productCode,  skipInventoryCheck,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="allowInactive"></param>
		/// <param name="customerAccountId"></param>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="skipInventoryCheck"></param>
		/// <param name="variationProductCode"></param>
		/// <param name="discountSelections"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.DiscountValidationSummary"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var discountValidationSummary = product.ValidateDiscounts( discountSelections,  productCode,  variationProductCode,  customerAccountId,  allowInactive,  skipInventoryCheck,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductRuntime.DiscountValidationSummary ValidateDiscounts(Mozu.Api.Contracts.ProductRuntime.DiscountSelections discountSelections, string productCode, string variationProductCode =  null, int? customerAccountId =  null, bool? allowInactive =  null, bool? skipInventoryCheck =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.DiscountValidationSummary> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductClient.ValidateDiscountsClient( discountSelections,  productCode,  variationProductCode,  customerAccountId,  allowInactive,  skipInventoryCheck,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.DiscountValidationSummary> ValidateDiscountsAsync(Mozu.Api.Contracts.ProductRuntime.DiscountSelections discountSelections, string productCode, string variationProductCode =  null, int? customerAccountId =  null, bool? allowInactive =  null, bool? skipInventoryCheck =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.DiscountValidationSummary> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductClient.ValidateDiscountsClient( discountSelections,  productCode,  variationProductCode,  customerAccountId,  allowInactive,  skipInventoryCheck,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="query"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.LocationInventoryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var locationInventoryCollection = product.GetProductInventories( query,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductRuntime.LocationInventoryCollection GetProductInventories(Mozu.Api.Contracts.ProductRuntime.LocationInventoryQuery query, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.LocationInventoryCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductClient.GetProductInventoriesClient( query,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.LocationInventoryCollection> GetProductInventoriesAsync(Mozu.Api.Contracts.ProductRuntime.LocationInventoryQuery query, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.LocationInventoryCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductClient.GetProductInventoriesClient( query,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


