
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

namespace Mozu.Api.Clients.Commerce.Settings
{
	/// <summary>
	/// Define global site settings such as the site name, shipping and email addresses, and logo images. Block undesirable IP addresses using this resource.
	/// </summary>
	public partial class GeneralSettingsClient 	{
		
		/// <summary>
		/// Retrieve a site's general global settings.
		/// </summary>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.General.GeneralSettings"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetGeneralSettings( responseFields);
		///   var generalSettingsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.General.GeneralSettings> GetGeneralSettingsClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.GeneralSettingsUrl.GetGeneralSettingsUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.General.GeneralSettings>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Updates a site's general global settings.
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="generalSettings">The properties of the site's general settings to update.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.General.GeneralSettings"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateGeneralSettings( generalSettings,  responseFields);
		///   var generalSettingsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.General.GeneralSettings> UpdateGeneralSettingsClient(Mozu.Api.Contracts.SiteSettings.General.GeneralSettings generalSettings, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.GeneralSettingsUrl.UpdateGeneralSettingsUrl(responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.General.GeneralSettings>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.SiteSettings.General.GeneralSettings>(generalSettings);
			return mozuClient;

		}


	}

}


