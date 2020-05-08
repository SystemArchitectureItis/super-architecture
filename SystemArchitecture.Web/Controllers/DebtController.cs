using System.Threading.Tasks;
using SystemArchitecture.Core;
using SystemArchitecture.Core.EntityServices;
using SystemArchitecture.Core.EntityServices.Base;
using SystemArchitecture.Models.Entities;
using SystemArchitecture.Web.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace SystemArchitecture.Web.Controllers
{
	public class DebtController : BaseController<Debt>
	{
		private readonly DebtService _service;

		public DebtController(DebtService service) : base(service)
		{
			_service = service;
		}

		public override async Task<IActionResult> Update([FromBody] Debt entity)
		{
			await _service.UpdateAsync(entity);
			return Successful();
		}
		
		public override async Task<IActionResult> Save([FromBody] Debt entity)
		{
			await _service.SaveAsync(entity);
			return Successful();
		}
	}
}