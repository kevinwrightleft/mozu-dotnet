
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


namespace Mozu.Api.Contracts.Event
{
		public class EventDeliverySummary
		{
			public DateTime? CreateDate { get; set; }

			public string DeliveryStatus { get; set; }

			public int? Id { get; set; }

			public bool IsRunning { get; set; }

			public DateTime LastExecutionDate { get; set; }

			public DateTime NextExecutionDate { get; set; }

			public int? RetriesRemaining { get; set; }

			public DateTime? UpdateDate { get; set; }

			public List<EventDeliveryAttempt> DeliveryAttempts { get; set; }

			public EventSummary EventSummary { get; set; }

		}

}