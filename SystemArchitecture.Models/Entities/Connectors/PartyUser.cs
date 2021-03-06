﻿using SystemArchitecture.Models.Entities.Base;

namespace SystemArchitecture.Models.Entities.Connectors
{
	public class PartyUser : HaveId
	{
		public long PartyId { get; set; }
		public virtual Party Party { get; set; }

		public long UserId { get; set; }
		public virtual User User { get; set; }
	}
}