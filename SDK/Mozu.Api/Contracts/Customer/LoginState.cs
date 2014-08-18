
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.Customer
{
		///
		///	Properties of the login state of a customer account.
		///
		public class LoginState
		{
			///
			///Date and time when the entity was created, represented in UTC Date/Time.
			///
			public DateTime? CreatedOn { get; set; }

			///
			///The total number of times the customer account has unsuccessfully attempted to log in.
			///
			public byte FailedLoginAttemptCount { get; set; }

			///
			///The date and time the customer's first unsuccessful attempt to log in was recorded.
			///
			public DateTime? FirstFailedLoginAttemptOn { get; set; }

			///
			///If true, the customer account is locked and the customer cannot log in.
			///
			public bool IsLocked { get; set; }

			///
			///If true, the customer account user must change the password for the account.
			///
			public bool IsPasswordChangeRequired { get; set; }

			///
			///The date and time the customer account was most recently locked.
			///
			public DateTime? LastLockedOn { get; set; }

			///
			///The date and time the customer account last logged in.
			///
			public DateTime? LastLoginOn { get; set; }

			///
			///The date and the time the user associated with the customer account last changed the account password.
			///
			public DateTime? LastPasswordChangeOn { get; set; }

			///
			///The remaining number of login attempts the customer can perform before the system locks the customer account.
			///
			public int RemainingLoginAttempts { get; set; }

			///
			///Date and time when the entity was last updated, represented in UTC Date/Time.
			///
			public DateTime? UpdatedOn { get; set; }

		}

}