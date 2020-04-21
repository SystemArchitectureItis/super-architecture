using System.Threading.Tasks;
using SystemArchitecture.Core;
using SystemArchitecture.Models;
using SystemArchitecture.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace SystemArchitecture.Web.Controllers
{
	public class UserController : BaseController<User>
	{
		private readonly PasswordService _passwordService;

		public UserController(DomainService<User> service, PasswordService passwordService) : base(service)
		{
			_passwordService = passwordService;
		}

		public override Task<IActionResult> Save(User entity)
		{
			if (!string.IsNullOrWhiteSpace(entity.Password))
				entity.Password = _passwordService.HashPassword(entity.Password);
			return base.Save(entity);
		}

		public override Task<IActionResult> Update(User entity)
		{
			if (!string.IsNullOrWhiteSpace(entity.Password))
				entity.Password = _passwordService.HashPassword(entity.Password);
			return base.Update(entity);
		}
	}
}