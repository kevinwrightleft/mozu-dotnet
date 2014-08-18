
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
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Properties of the category, price, or attribute facet shoppers use to filter product display results on a storefront.
		///
		public class Facet
		{
			///
			///Unique identifier for the storefront container used to organize products.
			///
			public int CategoryId { get; set; }

			///
			///Unique identifier of the facet.
			///
			public int? FacetId { get; set; }

			///
			///The type of facet. Valid values are "range," which enables creation of a range of values, or "value," which populates the facet values based on the associated attribute or category.
			///
			public string FacetType { get; set; }

			///
			///If true, disables a facet inherited from a parent category.
			///
			public bool IsHidden { get; set; }

			///
			///The numeric sequence of the facet for its associated category.
			///
			public int Order { get; set; }

			///
			///Overrides a facet inherited from a parent category for a specified subcategory. System-supplied and read only.
			///
			public int? OverrideFacetId { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///For range type facets, an array of ranges to use for the facet values. For example, a price facet might have range queries for $0-$25, $25-$50, and $50-$100.
			///
			public List<FacetRangeQuery> RangeQueries { get; set; }

			///
			///Container for the facet source information, which includes the category, price, or attribute properties.
			///
			public FacetSource Source { get; set; }

			///
			///System-supplied and read only parameter that validates a facet for its associated category.
			///
			public FacetValidity Validity { get; set; }

		}

}