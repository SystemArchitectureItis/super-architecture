using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using SystemArchitecture.Models.Entities.Base;
using SystemArchitecture.Models.Entities.Connectors;

namespace SystemArchitecture.Models.Entities
{
	/// <summary>
	/// Место/заведение
	/// </summary>
	public class Location : HaveId
	{
		/// <summary>
		/// Час открытия.
		/// </summary>
		/// <remarks>Важно только наличие часа, дата игнорируется</remarks>
		public DateTime OpenHour { get; set; }

		/// <summary>
		/// Час закрытия.
		/// </summary>
		/// <remarks>Важно только наличие часа, дата игнорируется</remarks>
		public DateTime CloseHour { get; set; }

		/// <summary>
		/// Адрес 
		/// </summary>
		public string Address { get; set; }

		/// <summary>
		/// Телефон
		/// </summary>
		[Phone]
		public string Phone { get; set; }

		/// <summary>
		/// Ссылка
		/// </summary>
		public Uri Link { get; set; }
		
		// /// <summary>
		// /// Связки мероприятий и мест.
		// /// </summary>
		// public virtual List<PartyLocation> PartyLocations { get; set; }
		//
		// /// <summary>
		// /// Список мероприятий.
		// /// </summary>
		// [NotMapped]
		// public IEnumerable<Party> Parties => PartyLocations?.Select(x => x.Party);
	}
}