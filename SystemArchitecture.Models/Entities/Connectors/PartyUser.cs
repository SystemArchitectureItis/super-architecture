using SystemArchitecture.Models.Entities.Base;

namespace SystemArchitecture.Models.Entities.Connectors
{
	public class PartyUser : HaveId
	{
		public Party Party { get; set; }
		public User User { get; set; }
	}
}