using SystemArchitecture.Models.Entities.Base;

namespace SystemArchitecture.Models.Entities
{
	/// <summary>
	/// Долг
	/// </summary>
	public class Debt : HaveId
	{
		/// <summary>
		/// Должник
		/// </summary>
		public virtual User Debtor { get; set; }

		/// <summary>
		/// Получатель долга
		/// </summary>
		public virtual User Creditor { get; set; }

		/// <summary>
		/// Флаг подтверждения перевода должником
		/// </summary>
		public bool DebtorApproval { get; set; }

		/// <summary>
		/// Флаг подтверждения получения получателем
		/// </summary>
		public bool CreditorApproval { get; set; }

		/// <summary>
		/// Размер
		/// </summary>
		public decimal DebtSize { get; set; }
	}
}