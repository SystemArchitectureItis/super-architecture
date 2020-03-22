using SystemArchitecture.Core;
using SystemArchitecture.Models.Entities;

namespace SystemArchitecture.Web.Controllers
{
	public class PurchaseController : BaseController<Purchase>
	{
		public PurchaseController(DomainService<Purchase> service) : base(service)
		{
		}
	}
}