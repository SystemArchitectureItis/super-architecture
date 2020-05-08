using System.Threading.Tasks;
using SystemArchitecture.Core.EntityServices;
using SystemArchitecture.Models.Entities;
using SystemArchitecture.Web.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace SystemArchitecture.Web.Controllers
{
	public class PurchaseController : BaseController<Purchase>
	{
		private readonly PurchaseService _service;

		public PurchaseController(PurchaseService service) : base(service)
		{
			_service = service;
		}
		
		public override async Task<IActionResult> Update([FromBody] Purchase entity)
		{
			await _service.UpdateAsync(entity);
			return Successful();
		}
		
		public override async Task<IActionResult> Save([FromBody] Purchase entity)
		{
			await _service.SaveAsync(entity);
			return Successful();
		}
	}
}