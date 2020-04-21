using System;
using System.ComponentModel.DataAnnotations.Schema;
using SystemArchitecture.Models.Entities.Base;

namespace SystemArchitecture.Models.Entities
{
	/// <summary>
	/// Мероприятие.
	/// </summary>
	public class Party : HaveId
	{
		public string Ref { get; set; }
		
		/// <summary>
		/// Наименование
		/// </summary>
		public string Title { get; set; }
		
		/// <summary>
		/// Описание
		/// </summary>
		public string Description { get; set; }
		
		/// <summary>
		/// Место
		/// </summary>
		public string Location { get; set; }
		
		/// <summary>
		/// Дата начала
		/// </summary>
		public DateTime DateStart { get; set; } = DateTime.Now;
		
		/// <summary>
		/// Дата конца
		/// </summary>
		public DateTime DateEnd { get; set; } = DateTime.Now;
		
		/// <summary>
		/// Пароль для входа в мероприятие
		/// </summary>
		public string Password { get; set; }
		
		/// <summary>
		/// Ссылка на картинку
		/// </summary>
		public Uri ImageUrl { get; set; }

		/// <summary>
		/// Список причастных пользователей
		/// </summary>
		[ForeignKey("PartyId")]
		public User[] Users { get; set; }
		
		/// <summary>
		/// Список покупок
		/// </summary>
		[ForeignKey("PartyId")]
		public Purchase[] PurchaseList { get; set; }
	}
}