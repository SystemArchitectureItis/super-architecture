using SystemArchitecture.Core;
using SystemArchitecture.Models.Entities;
using SystemArchitecture.Web.Controllers.Base;

namespace SystemArchitecture.Web.Controllers
{
	public class PurchaseController : BaseController<Purchase>
	{
		public PurchaseController(BaseDomainService<Purchase> service) : base(service)
		{
		}
	}
}