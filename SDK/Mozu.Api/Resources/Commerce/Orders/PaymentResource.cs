
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

namespace Mozu.Api.Resources.Commerce.Orders
{
	/// <summary>
	/// Use the Payments subresource to manage payment transactions for orders. Each transaction performed for an order represents an individual payment. For example, if an order totals $75.00 but the shopper has a $50.00 gift certificate, both the gift certificate transaction and the credit card transaction for the remaining $25.00 are recorded as payments for the order.
	/// </summary>
	public partial class PaymentResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public PaymentResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}
				
		/// <summary>
		/// Retrieves information about all payment transactions submitted for the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var payment = new Payment();
		///   var paymentCollection = payment.GetPayments( orderId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection GetPayments(string orderId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PaymentClient.GetPaymentsClient( orderId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection> GetPaymentsAsync(string orderId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PaymentClient.GetPaymentsClient( orderId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the list of all available payment actions dependent on the order payment status by specifying the order ID.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the payment.</param>
		/// <param name="paymentId">Unique identifer of the payment for which to retrieve available actions.</param>
		/// <returns>
		/// List{string}
		/// </returns>
		/// <example>
		/// <code>
		///   var payment = new Payment();
		///   var string = payment.GetAvailablePaymentActions( orderId,  paymentId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<string> GetAvailablePaymentActions(string orderId, string paymentId)
		{
			MozuClient<List<string>> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PaymentClient.GetAvailablePaymentActionsClient( orderId,  paymentId);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<List<string>> GetAvailablePaymentActionsAsync(string orderId, string paymentId)
		{
			MozuClient<List<string>> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PaymentClient.GetAvailablePaymentActionsClient( orderId,  paymentId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves information about a specific payment transaction submitted for the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the payment transaction.</param>
		/// <param name="paymentId">Unique identifier of the payment transaction submitted for the order.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.Payment"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var payment = new Payment();
		///   var payment = payment.GetPayment( orderId,  paymentId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Payments.Payment GetPayment(string orderId, string paymentId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.Payment> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PaymentClient.GetPaymentClient( orderId,  paymentId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Payments.Payment> GetPaymentAsync(string orderId, string paymentId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.Payment> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PaymentClient.GetPaymentClient( orderId,  paymentId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Performs the specified action for an individual order payment transaction.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the payment.</param>
		/// <param name="paymentId">Unique identifer of the payment for which to perform the action.</param>
		/// <param name="responseFields"></param>
		/// <param name="action">The action to perform for the payment. Possible values are AuthAndCapture, AuthorizePayment, CapturePayment, VoidPayment, CreditPayment, RequestCheck, ApplyCheck, DeclineCheck.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var payment = new Payment();
		///   var order = payment.PerformPaymentAction( action,  orderId,  paymentId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order PerformPaymentAction(Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction action, string orderId, string paymentId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PaymentClient.PerformPaymentActionClient( action,  orderId,  paymentId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> PerformPaymentActionAsync(Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction action, string orderId, string paymentId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PaymentClient.PerformPaymentActionClient( action,  orderId,  paymentId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates a new payment transaction for the specified order and performs the specified action.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order for which to apply the payment.</param>
		/// <param name="responseFields"></param>
		/// <param name="action">To action to perform for the newly created payment. Possible values are AuthAndCapture, AuthorizePayment, CapturePayment, VoidPayment, CreditPayment, RequestCheck, ApplyCheck, DeclineCheck.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var payment = new Payment();
		///   var order = payment.CreatePaymentAction( action,  orderId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order CreatePaymentAction(Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction action, string orderId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PaymentClient.CreatePaymentActionClient( action,  orderId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> CreatePaymentActionAsync(Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction action, string orderId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PaymentClient.CreatePaymentActionClient( action,  orderId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


