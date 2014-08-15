
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


namespace Mozu.Api.Contracts.ShippingRuntime
{
		///
		///	Properties of a custom attribute used to integrate with a shipping provider, which consists of an array of necessary key-value pairs.
		///
		public class CustomAttribute
		{
			///
			///Key required for a custom attribute associated with a shipping provider integration, as part of a key-value pair.
			///
			public string Key { get; set; }

			///
			///Value for a custom attribute associated with a shipping provider integration, as part of a key-value pair.
			///
			public string Value { get; set; }

			///
			///Collection of child attributes associated with a shipping provider integration.
			///
			public List<CustomAttribute> ChildAttributes { get; set; }

		}

}