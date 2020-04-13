using System;
using System.ComponentModel.DataAnnotations.Schema;
using SystemArchitecture.Models.Entities.Base;

namespace SystemArchitecture.Models.Entities
{
	public class Party : BaseEntity
	{
		public string Ref { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Location { get; set; }
		public DateTime Date { get; set; } = DateTime.Now;
		public string Password { get; set; }
		public Uri ImageUrl { get; set; }

		[NotMapped]
		public User[] Users { get; set; }
		[NotMapped]
		public Purchase[] PurchaseList { get; set; }
	}
}