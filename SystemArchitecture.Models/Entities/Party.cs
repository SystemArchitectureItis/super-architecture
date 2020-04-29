using System;
using System.Collections.Generic;
using SystemArchitecture.Models.Entities.Base;
using SystemArchitecture.Models.Entities.Connectors;

namespace SystemArchitecture.Models.Entities
{
	/// <summary>
	/// Мероприятие.
	/// </summary>
	public class Party : HaveId
	{
		/// <summary>
		/// Наименование
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Описание
		/// </summary>
		public string Description { get; set; }

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

		// /// <summary>
		// /// Связки пользователей и мероприятия.
		// /// </summary>
		// public virtual List<PartyUser> PartyUsers { get; set; }
		//
		// /// <summary>
		// /// Список пользователей.
		// /// </summary>
		// [NotMapped]
		// public IEnumerable<User> Users => PartyUsers?.Select(x => x.User);

		// /// <summary>
		// /// Список покупок.
		// /// </summary>
		// public virtual List<Purchase> PurchaseList { get; set; }

		// /// <summary>
		// /// Связка мест и мероприятий.
		// /// </summary>
		// public virtual List<PartyLocation> PartyLocations { get; set; }
		//
		// /// <summary>
		// /// Места мероприятия.
		// /// </summary>
		// [NotMapped]
		// public IEnumerable<Location> Locations => PartyLocations?.Select(x => x.Location);
	}
}