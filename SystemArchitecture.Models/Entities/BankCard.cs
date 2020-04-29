using System;
using System.ComponentModel.DataAnnotations;
using SystemArchitecture.Models.Entities.Base;

namespace SystemArchitecture.Models.Entities
{
	/// <summary>
	/// Кредитная карта.
	/// </summary>
	public class BankCard : HaveId
	{
		/// <summary>
		/// Номер карты.
		/// </summary>
		[CreditCard]
		[Required]
		public string Number { get; set; }

		/// <summary>
		/// Срок окончания валидности карты.
		/// </summary>
		[Required]
		public DateTime ValidationDeadline { get; set; }

		/// <summary>
		/// Держатель карты
		/// </summary>
		[Required]
		public virtual User CardHolder { get; set; }
	}
}