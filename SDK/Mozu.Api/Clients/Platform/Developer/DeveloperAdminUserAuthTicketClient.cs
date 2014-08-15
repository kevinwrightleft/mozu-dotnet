
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

namespace Mozu.Api.Clients.Platform.Developer
{
	/// <summary>
	/// Use this resource to manage authentication tickets for your developer account.
	/// </summary>
	public partial class DeveloperAdminUserAuthTicketClient 	{
		
		/// <summary>
		/// Generate an authentication ticket for a developer account.
		/// </summary>
		/// <param name="developerAccountId">Unique identifier of the developer account.</param>
		/// <param name="userAuthInfo">The user authentication information required to generate the developer account user authentication ticket, which consists of a user name and password.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateDeveloperUserAuthTicket( userAuthInfo,  developerAccountId);
		///   var developerAdminUserAuthTicketClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket> CreateDeveloperUserAuthTicketClient(Mozu.Api.Contracts.Core.UserAuthInfo userAuthInfo, int? developerAccountId =  null)
		{
			var url = Mozu.Api.Urls.Platform.Developer.DeveloperAdminUserAuthTicketUrl.CreateDeveloperUserAuthTicketUrl(developerAccountId);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Core.UserAuthInfo>(userAuthInfo);
			return mozuClient;

		}

		/// <summary>
		/// Generates a new developer account authentication ticket for the specified tenant by supplying the defined refresh token information.
		/// </summary>
		/// <param name="developerAccountId">Unique identifier of the developer account.</param>
		/// <param name="existingAuthTicket">Properties of the authentication ticket to refresh. The refresh token is required to complete this request.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RefreshDeveloperAuthTicket( existingAuthTicket,  developerAccountId);
		///   var developerAdminUserAuthTicketClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket> RefreshDeveloperAuthTicketClient(Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket existingAuthTicket, int? developerAccountId =  null)
		{
			var url = Mozu.Api.Urls.Platform.Developer.DeveloperAdminUserAuthTicketUrl.RefreshDeveloperAuthTicketUrl(developerAccountId);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket>(existingAuthTicket);
			return mozuClient;

		}

		/// <summary>
		/// Deletes the authentication ticket for the developer account by supplying the refresh token.
		/// </summary>
		/// <param name="refreshToken">Refresh token string associated with the developer account authentication ticket.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteUserAuthTicket( refreshToken);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteUserAuthTicketClient(string refreshToken)
		{
			var url = Mozu.Api.Urls.Platform.Developer.DeveloperAdminUserAuthTicketUrl.DeleteUserAuthTicketUrl(refreshToken);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}

