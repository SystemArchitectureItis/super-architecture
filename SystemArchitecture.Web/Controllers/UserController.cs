using SystemArchitecture.Core;
using SystemArchitecture.Models.Entities;

namespace SystemArchitecture.Web.Controllers
{
	public class UserController : BaseController<User>
	{
		public UserController(DomainService<User> service) : base(service)
		{
		}
	}
}