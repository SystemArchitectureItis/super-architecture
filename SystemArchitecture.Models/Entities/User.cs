using System;
using System.ComponentModel.DataAnnotations;
using SystemArchitecture.Models.Entities.Base;
using SystemArchitecture.Models.Infrastructure;

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
		[RequiredNotNull]
		public string FirstName { get; set; }
		
		/// <summary>
		/// Фамилия
		/// </summary>
		[RequiredNotNull]
		public string LastName { get; set; }

		/// <summary>
		/// Пароль в хешированном виде
		/// </summary>
		[RequiredNotNull]
		public string Password { get; set; }

		/// <summary>
		/// Телефон
		/// </summary>
		[Phone]
		public string PhoneNumber { get; set; }
		
		/// <summary>
		/// Email
		/// </summary>
		[EmailAddress]
		public string Email { get; set; }

		/// <summary>
		/// Фотография
		/// </summary>
		public Uri ImageUrl { get; set; }

		// /// <summary>
		// /// Связки мероприятий и пользователя.
		// /// </summary>
		// public virtual List<PartyUser> PartyUsers { get; set; }
		//
		// /// <summary>
		// /// Список мероприятий.
		// /// </summary>
		// [NotMapped]
		// public IEnumerable<Party> Parties => PartyUsers?.Select(x => x.Party);
	}
}