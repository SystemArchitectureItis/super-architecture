using SystemArchitecture.Core;
using SystemArchitecture.Models.Entities;

namespace SystemArchitecture.Web.Controllers
{
	public class PartyController : BaseController<Party>
	{
		public PartyController(DomainService<Party> service) : base(service)
		{
		}
	}
}