
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


namespace Mozu.Api.Contracts.Reference
{
		///
		///	The paged collection of country codes and their corresponding names.
		///
		public class CountryCollection
		{
			///
			///The number of results listed in the query collection, represented by a signed 64-bit (8-byte) integer. This value is system-supplied and read-only.
			///
			public long TotalCount { get; set; }

			///
			///An array list of objects in the returned collection.
			///
			public List<Country> Items { get; set; }

		}

}