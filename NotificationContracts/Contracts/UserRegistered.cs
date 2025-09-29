using System;

namespace NotificationContracts.Contracts
{
	public class UserRegistered
	{
		public Guid UserId { get; set; }
		public string Email { get; set; }
		public string UserName { get; set; }
		public string Body { get; set; }
	}
}
