
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

namespace Mozu.Api.Clients.Platform.Adminuser
{
	/// <summary>
	/// Displays the user accounts and account details associated with a developer or Mozu tenant administrator. Email addresses uniquely identify admin user accounts.
	/// </summary>
	public partial class AdminUserClient 	{
		
		/// <summary>
		/// Retrieves a list of the Mozu tenants or development stores for which the specified user has an assigned role.
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="userId">Unique identifier of the user whose tenant scopes you want to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Tenant.TenantCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetTenantScopesForUser( userId,  responseFields);
		///   var tenantCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Tenant.TenantCollection> GetTenantScopesForUserClient(string userId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.Adminuser.AdminUserUrl.GetTenantScopesForUserUrl(userId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Tenant.TenantCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of the specified administrator user account.
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="userId">Unique identifier of the administrator account to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Core.User"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetUser( userId,  responseFields);
		///   var userClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Core.User> GetUserClient(string userId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.Adminuser.AdminUserUrl.GetUserUrl(userId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Core.User>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


