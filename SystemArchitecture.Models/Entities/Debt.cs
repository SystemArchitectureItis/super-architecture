using SystemArchitecture.Models.Entities.Base;

namespace SystemArchitecture.Models.Entities
{
	/// <summary>
	/// Долг
	/// </summary>
	public class Debt : HaveId
	{
		/// <summary>
		/// Размер
		/// </summary>
		public decimal DebtSize { get; set; }
		
		public string Ref { get; set; }
		
		/// <summary>
		/// Должник
		/// </summary>
		public User Debtor { get; set; }
		
		/// <summary>
		/// Получатель долга
		/// </summary>
		public User Creditor { get; set; }
		
		/// <summary>
		/// Флаг подтверждения перевода должником
		/// </summary>
		public bool DebtorApproval { get; set; }
		
		/// <summary>
		/// Флаг подтверждения получения получателем
		/// </summary>
		public bool CreditorApproval { get; set; }
	}
}