using System.Threading.Tasks;
using SystemArchitecture.Core.EntityServices.Base;
using SystemArchitecture.Models.Entities.Base;
using SystemArchitecture.Models.Infrastructure;
using SystemArchitecture.Web.Filters;
using Microsoft.AspNetCore.Mvc;

namespace SystemArchitecture.Web.Controllers.Base
{
	[PrettyFilter]
	[Route("[controller]/[action]")]
	public class BaseController<T> : Controller where T : HaveId
	{
		protected readonly BaseDomainService<T> Service;

		public BaseController(BaseDomainService<T> service)
		{
			Service = service;
		}

		[HttpPost]
		public virtual async Task<IActionResult> Delete(long id)
		{
			await Service.DeleteAsync(id);
			return Ok();
		}

		[HttpGet]
		public virtual async Task<IActionResult> Get(long id)
		{
			var data = await Service.GetAsync(id);
			return Ok(data);
		}

		[HttpGet]
		public virtual async Task<IActionResult> GetAll()
		{
			var data = await Service.GetAllAsync();
			return Ok(data);
		}

		[HttpPost]
		public virtual async Task<IActionResult> Update([FromBody] T entity)
		{
			await Service.UpdateAsync(entity);
			return Ok();
		}

		[HttpPost]
		public virtual async Task<IActionResult> Save([FromBody] T entity)
		{
			await Service.SaveAsync(entity);
			return Ok();
		}

		protected IActionResult Successful()
		{
			return new OkObjectResult(Result.Successful());
		}
		
		protected IActionResult Failure(string message)
		{
			return new OkObjectResult(Result.Failure(message));
		}
	}
}