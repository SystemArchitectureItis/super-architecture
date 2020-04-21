using System;
using System.ComponentModel.DataAnnotations.Schema;
using SystemArchitecture.Models.Entities.Base;

namespace SystemArchitecture.Models.Entities
{
	/// <summary>
	/// Покупка
	/// </summary>
	public class Purchase : HaveId
	{
		/// <summary>
		/// Наименование товара/услуги
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Цена
		/// </summary>
		public decimal Price { get; set; }

		/// <summary>
		/// Покупатель
		/// </summary>
		public User Creditor { get; set; }

		/// <summary>
		/// Фотография товара/услуги
		/// </summary>
		public Uri ImageUrl { get; set; }

		/// <summary>
		/// Фотография чека
		/// </summary>
		public Uri CheckUrl { get; set; }

		// ссылка на мероприятие расположена в классе Party.

		[ForeignKey("PurchaseId")] public User[] UserList { get; set; }
	}
}