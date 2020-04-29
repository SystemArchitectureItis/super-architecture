using System.Threading.Tasks;
using SystemArchitecture.Core;
using SystemArchitecture.Models.Entities;
using SystemArchitecture.Web.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace SystemArchitecture.Web.Controllers
{
	public class LocationController : BaseController<Location>
	{
		public LocationController(BaseDomainService<Location> service) : base(service)
		{
		}

		public override Task<IActionResult> Save(Location entity)
		{
			return base.Save(entity);
		}
	}
}