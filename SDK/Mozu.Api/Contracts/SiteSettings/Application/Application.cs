
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


namespace Mozu.Api.Contracts.SiteSettings.Application
{
		///
		///	Properties of an application installed in a tenant.
		///
		public class Application
		{
			///
			///The unique identifier of the application in Mozu Dev Center.
			///
			public string AppId { get; set; }

			///
			///If true, the application is enabled for the tenant. System-supplied and read-only.
			///
			public bool? Enabled { get; set; }

			///
			///If true, the third party application settings have been configured and the application is initialized.
			///
			public bool? Initialized { get; set; }

			public bool? IsExtension { get; set; }

			///
			///URL of the application's setting configuration user interface, supplied by the capability developer in Dev Center.
			///
			public string UiConfigurationUrl { get; set; }

			///
			///List of capabilities installed in a tenant.
			///
			public List<Capability> Capabilities { get; set; }

		}

}