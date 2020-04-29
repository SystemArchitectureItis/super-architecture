using SystemArchitecture.Models.Entities.Base;

namespace SystemArchitecture.Models.Entities.Connectors
{
	public class PartyLocation : HaveId
	{
		public long PartyId { get; set; }
		public virtual Party Party { get; set; }

		public long LocationId { get; set; }
		public virtual Location Location { get; set; }
	}
}