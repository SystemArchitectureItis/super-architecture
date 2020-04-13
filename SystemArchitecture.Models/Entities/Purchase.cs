using System;
using System.ComponentModel.DataAnnotations.Schema;
using SystemArchitecture.Models.Entities.Base;

namespace SystemArchitecture.Models.Entities
{
	public class Purchase : BaseEntity
	{
		public string Title { get; set; }
		public decimal Price { get; set; }
		public User Creditor { get; set; }
		public Uri ImageUrl { get; set; }
		public Uri CheckUrl { get; set; }

		[NotMapped]
		public User[] UserList { get; set; }
	}
}