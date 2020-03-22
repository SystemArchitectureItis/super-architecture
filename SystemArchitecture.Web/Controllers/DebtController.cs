using SystemArchitecture.Core;
using SystemArchitecture.Models.Entities;

namespace SystemArchitecture.Web.Controllers
{
	public class DebtController : BaseController<Debt>
	{
		public DebtController(DomainService<Debt> service) : base(service)
		{
		}
	}
}