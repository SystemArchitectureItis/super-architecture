using System;
using System.ComponentModel.DataAnnotations;
using SystemArchitecture.Models.Entities.Base;

namespace SystemArchitecture.Models.Entities
{
	public class UserDebtor : HaveId
	{
		public string Name { get; set; }
		[Phone] public string PhoneNumber { get; set; }
		[CreditCard] public string CardNumber { get; set; }
		public decimal DebtSize { get; set; }
		public Uri ImageUrl { get; set; }
		public string DebtRef { get; set; }
	}
}