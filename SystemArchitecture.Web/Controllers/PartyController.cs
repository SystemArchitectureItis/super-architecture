using SystemArchitecture.Core;
using SystemArchitecture.Models.Entities;
using SystemArchitecture.Web.Controllers.Base;

namespace SystemArchitecture.Web.Controllers
{
	public class PartyController : BaseController<Party>
	{
		public PartyController(BaseDomainService<Party> service) : base(service)
		{
		}
	}
}