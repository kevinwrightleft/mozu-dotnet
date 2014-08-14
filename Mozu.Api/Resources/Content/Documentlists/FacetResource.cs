
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


namespace Mozu.Api.Resources.Content.Documentlists
{
	/// <summary>
	/// Use the facets subresource to allow a merchant to add information for product indexing and searching.
	/// </summary>
	public partial class FacetResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		public FacetResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves the properties of facets that aid in indexing and searching.
		/// </summary>
		/// <param name="documentListName">The document list associated with the facets to retrieve.</param>
		/// <param name="propertyName">The property name associated with the facets to retrieve.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.Content.Facet"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var facet = new Facet();
		///   var facet = facet.GetFacets(dataViewMode,  documentListName,  propertyName);
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.Content.Facet> GetFacets(DataViewMode dataViewMode, string documentListName, string propertyName)
		{
			MozuClient<List<Mozu.Api.Contracts.Content.Facet>> response;
			var client = Mozu.Api.Clients.Content.Documentlists.FacetClient.GetFacetsClient(dataViewMode,  documentListName,  propertyName);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}


	}

}

