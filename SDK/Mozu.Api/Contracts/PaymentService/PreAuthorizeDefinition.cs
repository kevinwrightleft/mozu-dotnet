
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Mozu.Api.Contracts.PaymentService
{
		public class PreAuthorizeDefinition
		{
			///
			///Identifier of the entity.
			///
			public int Id { get; set; }

			public string PreAuthorizeProdUrl { get; set; }

			public string PreAuthorizeTestUrl { get; set; }

			public PreAuthorizeTransactionTypeDataContract Type { get; set; }

		}

}