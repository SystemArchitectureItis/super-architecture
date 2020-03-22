using SystemArchitecture.Models.Entities.Base;

namespace SystemArchitecture.Models.Entities
{
	public class Debt : BaseEntity
	{
		public decimal DebtSize { get; set; }
		public string Ref { get; set; }
		public User Debtor { get; set; }
		public User Creditor { get; set; }
		public bool DebtorApproval { get; set; }
		public bool CreditorApproval { get; set; }
	}
}