using System;
using SystemArchitecture.Models.Entities.Base;

namespace SystemArchitecture.Models.Entities
{
	/// <summary>
	/// Покупка
	/// </summary>
	public class Purchase : HaveId
	{
		/// <summary>
		/// Мероприятие.
		/// </summary>
		public virtual Party Party { get; set; }
		
		/// <summary>
		/// Наименование товара/услуги
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Цена
		/// </summary>
		public decimal Price { get; set; }

		/// <summary>
		/// Фотография товара/услуги
		/// </summary>
		public Uri ImageUrl { get; set; }

		/// <summary>
		/// Фотография чека
		/// </summary>
		public Uri CheckUrl { get; set; }
	}
}