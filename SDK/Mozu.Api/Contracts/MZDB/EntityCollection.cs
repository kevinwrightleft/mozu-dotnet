
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
using Newtonsoft.Json.Linq;


namespace Mozu.Api.Contracts.MZDB
{
		public class EntityCollection
		{
			public int PageCount { get; set; }

			public int PageSize { get; set; }

			public int StartIndex { get; set; }

			public int TotalCount { get; set; }

			public List<JObject> Items { get; set; }

		}

}