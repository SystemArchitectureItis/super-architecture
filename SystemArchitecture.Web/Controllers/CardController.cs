using System.Threading.Tasks;
using SystemArchitecture.Core.EntityServices;
using SystemArchitecture.Models.Entities;
using SystemArchitecture.Web.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace SystemArchitecture.Web.Controllers
{
	public class CardController : BaseController<BankCard>
	{
		private readonly CardService _service;

		public CardController(CardService service) : base(service)
		{
			_service = service;
		}

		public override async Task<IActionResult> Update([FromBody] BankCard entity)
		{
			await _service.UpdateAsync(entity);
			return Successful();
		}
		
		public override async Task<IActionResult> Save([FromBody] BankCard entity)
		{
			await _service.SaveAsync(entity);
			return Successful();
		}
	}
}