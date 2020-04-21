using System;
using System.ComponentModel.DataAnnotations;
using SystemArchitecture.Models.Entities.Base;

namespace SystemArchitecture.Models.Entities
{
	/// <summary>
	/// Пользователь
	/// </summary>
	public class User : HaveId
	{
		/// <summary>
		/// Имя
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Пароль в хешированном виде
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// Телефон
		/// </summary>
		[Phone]
		public string PhoneNumber { get; set; }

		/// <summary>
		/// Карта
		/// </summary>
		[CreditCard]
		public string CardNumber { get; set; }

		/// <summary>
		/// Фотография
		/// </summary>
		public Uri ImageUrl { get; set; }
	}
}