
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

namespace Mozu.Api.Clients.Platform
{
	/// <summary>
	/// Use the site data resource to store site-level information required for a third-party application in the Mozu database.
	/// </summary>
	public partial class SiteDataClient 	{
		
		/// <summary>
		/// Retrieves the value of a record in the Mozu database.
		/// </summary>
		/// <param name="dbEntryQuery">The database entry query string used to retrieve the record information.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{string}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDBValue( dbEntryQuery,  responseFields);
		///   var stringClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<string> GetDBValueClient(string dbEntryQuery, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.SiteDataUrl.GetDBValueUrl(dbEntryQuery, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<string>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a new record in the Mozu database based on the information supplied in the request.
		/// </summary>
		/// <param name="dbEntryQuery">The database entry string to create.</param>
		/// <param name="value">The value string to create.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateDBValue( value,  dbEntryQuery);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient CreateDBValueClient(string value, string dbEntryQuery)
		{
			var url = Mozu.Api.Urls.Platform.SiteDataUrl.CreateDBValueUrl(dbEntryQuery);
			const string verb = "POST";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody(value);
			return mozuClient;

		}

		/// <summary>
		/// Updates a record in the Mozu database based on the information supplied in the request.
		/// </summary>
		/// <param name="dbEntryQuery">The database entry query string used to update the record information.</param>
		/// <param name="value">The database value to update.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateDBValue( value,  dbEntryQuery);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient UpdateDBValueClient(string value, string dbEntryQuery)
		{
			var url = Mozu.Api.Urls.Platform.SiteDataUrl.UpdateDBValueUrl(dbEntryQuery);
			const string verb = "PUT";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody(value);
			return mozuClient;

		}

		/// <summary>
		/// Removes a previously defined record in the Mozu database.
		/// </summary>
		/// <param name="dbEntryQuery">The database entry string to delete.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteDBValue( dbEntryQuery);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteDBValueClient(string dbEntryQuery)
		{
			var url = Mozu.Api.Urls.Platform.SiteDataUrl.DeleteDBValueUrl(dbEntryQuery);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


