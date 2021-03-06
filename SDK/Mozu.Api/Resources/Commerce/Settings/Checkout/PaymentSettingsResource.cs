
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

namespace Mozu.Api.Resources.Commerce.Settings.Checkout
{
	/// <summary>
	/// Specify settings when creating payments for order checkout on the site.
	/// </summary>
	public partial class PaymentSettingsResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public PaymentSettingsResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public PaymentSettingsResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new PaymentSettingsResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves the details of the third-party payment service workflows configured for the site.
		/// </summary>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var paymentsettings = new PaymentSettings();
		///   var externalPaymentWorkflowDefinition = paymentsettings.GetThirdPartyPaymentWorkflows();
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition> GetThirdPartyPaymentWorkflows()
		{
			MozuClient<List<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition>> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.PaymentSettingsClient.GetThirdPartyPaymentWorkflowsClient();
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<List<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition>> GetThirdPartyPaymentWorkflowsAsync()
		{
			MozuClient<List<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition>> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.PaymentSettingsClient.GetThirdPartyPaymentWorkflowsClient();
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


