using SystemArchitecture.Core.EntityServices.Base;
using SystemArchitecture.Models.Entities;
using SystemArchitecture.Web.Controllers.Base;

namespace SystemArchitecture.Web.Controllers
{
	public class LocationController : BaseController<Location>
	{
		public LocationController(BaseDomainService<Location> service) : base(service)
		{
		}
	}
}