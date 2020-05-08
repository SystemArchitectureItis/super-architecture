using System.Threading.Tasks;
using SystemArchitecture.Core.EntityServices;
using SystemArchitecture.Models.Entities;
using SystemArchitecture.Web.Controllers.Base;
using SystemArchitecture.Web.Filters;
using Microsoft.AspNetCore.Mvc;

namespace SystemArchitecture.Web.Controllers
{
	[PrettyFilter]
	public class UserController : BaseController<User>
	{
		private readonly UserService _service;

		public UserController(UserService service) : base(service)
		{
			_service = service;
		}

		public override async Task<IActionResult> Save([FromBody] User entity)
		{
			await _service.SaveAsync(entity);
			return Successful();
		}

		public override async Task<IActionResult> Update([FromBody] User entity)
		{
			await _service.UpdateAsync(entity);
			return Successful();
		}
	}
}