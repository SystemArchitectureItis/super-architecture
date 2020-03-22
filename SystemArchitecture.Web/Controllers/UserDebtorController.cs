using SystemArchitecture.Core;
using SystemArchitecture.Models.Entities;

namespace SystemArchitecture.Web.Controllers
{
	public class UserDebtorController : BaseController<UserDebtor>
	{
		public UserDebtorController(DomainService<UserDebtor> service) : base(service)
		{
		}
	}
}