
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

namespace Mozu.Api.Resources.Commerce
{
	/// <summary>
	/// Use the Orders resource to manage all components of order processing, payment, and fulfillment.
	/// </summary>
	public partial class OrderResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public OrderResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public OrderResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new OrderResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves a list of orders according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. You can filter an order's search results by any of its properties, including status, contact information, or total. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=Status+eq+Submitted"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="q">A list of order search terms to use in the query when searching across order number and the name or email of the billing contact. Separate multiple search terms with a space character.</param>
		/// <param name="qLimit">The maximum number of search results to return in the response. You can limit any range between 1-100.</param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var orderCollection = order.GetOrders( startIndex,  pageSize,  sortBy,  filter,  q,  qLimit,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.OrderCollection GetOrders(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string q =  null, int? qLimit =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderCollection> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.GetOrdersClient( startIndex,  pageSize,  sortBy,  filter,  q,  qLimit,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderCollection> GetOrdersAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string q =  null, int? qLimit =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderCollection> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.GetOrdersClient( startIndex,  pageSize,  sortBy,  filter,  q,  qLimit,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves available order actions which depends on the status of the order. Actions are "CreateOrder," "SubmitOrder," "SetOrderAsProcessing," "CloseOrder," or "CancelOrder."
		/// </summary>
		/// <param name="orderId">Unique identifier of the available order actions to get.</param>
		/// <returns>
		/// List{string}
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var string = order.GetAvailableActions( orderId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<string> GetAvailableActions(string orderId)
		{
			MozuClient<List<string>> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.GetAvailableActionsClient( orderId);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<List<string>> GetAvailableActionsAsync(string orderId)
		{
			MozuClient<List<string>> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.GetAvailableActionsClient( orderId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.PricingRuntime.TaxableOrder"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var taxableOrder = order.GetTaxableOrders( orderId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.PricingRuntime.TaxableOrder> GetTaxableOrders(string orderId)
		{
			MozuClient<List<Mozu.Api.Contracts.PricingRuntime.TaxableOrder>> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.GetTaxableOrdersClient( orderId);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<List<Mozu.Api.Contracts.PricingRuntime.TaxableOrder>> GetTaxableOrdersAsync(string orderId)
		{
			MozuClient<List<Mozu.Api.Contracts.PricingRuntime.TaxableOrder>> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.GetTaxableOrdersClient( orderId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of an order specified by the order ID.
		/// </summary>
		/// <param name="draft">If true, retrieve the draft version of the order, which might include uncommitted changes to the order or its components.</param>
		/// <param name="orderId">Unique identifier of the order details to get.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = order.GetOrder( orderId,  draft,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order GetOrder(string orderId, bool? draft =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.GetOrderClient( orderId,  draft,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> GetOrderAsync(string orderId, bool? draft =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.GetOrderClient( orderId,  draft,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates a new order from an existing cart when the customer chooses to proceed to checkout.
		/// </summary>
		/// <param name="cartId">Unique identifier of the cart. This is the original cart ID expressed as a GUID.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = order.CreateOrderFromCart( cartId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order CreateOrderFromCart(string cartId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.CreateOrderFromCartClient( cartId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> CreateOrderFromCartAsync(string cartId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.CreateOrderFromCartClient( cartId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates a new order for no-cart quick-ordering scenarios.
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="order">All properties of the order to place.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = order.CreateOrder( order,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order CreateOrder(Mozu.Api.Contracts.CommerceRuntime.Orders.Order order, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.CreateOrderClient( order,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> CreateOrderAsync(Mozu.Api.Contracts.CommerceRuntime.Orders.Order order, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.CreateOrderClient( order,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Perform the specified action for an order. Available actions depend on the current status of the order. When in doubt, first get a list of available order actions.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields"></param>
		/// <param name="action">Action to perform, which can be "CreateOrder," "SubmitOrder," "SetOrderAsProcessing," "CloseOrder," or "CancelOrder."</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = order.PerformOrderAction( action,  orderId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order PerformOrderAction(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAction action, string orderId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.PerformOrderActionClient( action,  orderId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> PerformOrderActionAsync(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAction action, string orderId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.PerformOrderActionClient( action,  orderId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Update the properties of a discount applied to an order.
		/// </summary>
		/// <param name="discountId">Unique identifier of the discount. System-supplied and read only.</param>
		/// <param name="orderId">Unique identifier of the order discount. System-supplied and read only.</param>
		/// <param name="responseFields"></param>
		/// <param name="updateMode">Specifies whether to modify the discount by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
		/// <param name="version">System-supplied integer that represents the current version of the order, which prevents users from unintentionally overriding changes to the order. When a user performs an operation for a defined order, the system validates that the version of the updated order matches the version of the order on the server. After the operation completes successfully, the system increments the version number by one.</param>
		/// <param name="discount">Properties of the order discount to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = order.UpdateOrderDiscount( discount,  orderId,  discountId,  updateMode,  version,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateOrderDiscount(Mozu.Api.Contracts.CommerceRuntime.Discounts.AppliedDiscount discount, string orderId, int discountId, string updateMode =  null, string version =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.UpdateOrderDiscountClient( discount,  orderId,  discountId,  updateMode,  version,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> UpdateOrderDiscountAsync(Mozu.Api.Contracts.CommerceRuntime.Discounts.AppliedDiscount discount, string orderId, int discountId, string updateMode =  null, string version =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.UpdateOrderDiscountClient( discount,  orderId,  discountId,  updateMode,  version,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes the current draft version of the order, which also deletes any uncommitted changes made to the order in draft mode.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the draft to delete.</param>
		/// <param name="version">If applicable, the version of the order draft to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   order.DeleteOrderDraft( orderId,  version);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteOrderDraft(string orderId, string version =  null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.DeleteOrderDraftClient( orderId,  version);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		public virtual async Task DeleteOrderDraftAsync(string orderId, string version =  null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.DeleteOrderDraftClient( orderId,  version);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// Updates the user ID of the shopper who placed the order to the current user.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = order.ChangeOrderUserId( orderId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order ChangeOrderUserId(string orderId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.ChangeOrderUserIdClient( orderId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> ChangeOrderUserIdAsync(string orderId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.ChangeOrderUserIdClient( orderId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates the specified order when additional order information, such as shipping or billing information, is modified during the checkout process.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order to update.</param>
		/// <param name="responseFields"></param>
		/// <param name="updateMode">Specifies whether to update the original order, update the order in draft mode, or update the order in draft mode and then commit the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
		/// <param name="version">System-supplied integer that represents the current version of the order, which prevents users from unintentionally overriding changes to the order. When a user performs an operation for a defined order, the system validates that the version of the updated order matches the version of the order on the server. After the operation completes successfully, the system increments the version number by one.</param>
		/// <param name="order">The properties of the order to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = order.UpdateOrder( order,  orderId,  updateMode,  version,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateOrder(Mozu.Api.Contracts.CommerceRuntime.Orders.Order order, string orderId, string updateMode =  null, string version =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.UpdateOrderClient( order,  orderId,  updateMode,  version,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> UpdateOrderAsync(Mozu.Api.Contracts.CommerceRuntime.Orders.Order order, string orderId, string updateMode =  null, string version =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.UpdateOrderClient( order,  orderId,  updateMode,  version,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


