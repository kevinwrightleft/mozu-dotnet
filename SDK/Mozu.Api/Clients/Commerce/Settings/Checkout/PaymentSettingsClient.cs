
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

namespace Mozu.Api.Clients.Commerce.Settings.Checkout
{
	/// <summary>
	/// Specify settings when creating payments for order checkout on the site.
	/// </summary>
	public partial class PaymentSettingsClient 	{
		
		/// <summary>
		/// Retrieves the details of the third-party payment service workflows configured for the site.
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetThirdPartyPaymentWorkflows();
		///   var externalPaymentWorkflowDefinitionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition>> GetThirdPartyPaymentWorkflowsClient()
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Checkout.PaymentSettingsUrl.GetThirdPartyPaymentWorkflowsUrl();
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


