﻿using System.Threading.Tasks;
using SystemArchitecture.Core;
using SystemArchitecture.Models.Entities.Base;
using Microsoft.AspNetCore.Mvc;

namespace SystemArchitecture.Web.Controllers
{
	[Route("[controller]/[action]")]
	public class BaseController<T> : Controller where T : HaveId
	{
		private readonly DomainService<T> _service;

		public BaseController(DomainService<T> service)
		{
			_service = service;
		}

		[HttpPost]
		public virtual async Task<IActionResult> Delete(T entity)
		{
			await _service.DeleteAsync(entity.Id);
			return Ok();
		}

		[HttpGet]
		public virtual async Task<IActionResult> Get(T entity)
		{
			var data = await _service.GetAsync(entity.Id);
			return Ok(data);
		}

		[HttpGet]
		public virtual async Task<IActionResult> GetAll()
		{
			var data = await _service.GetAllAsync();
			return Ok(data);
		}

		[HttpPost]
		public virtual async Task<IActionResult> Update(T entity)
		{
			await _service.UpdateAsync(entity);
			return Ok();
		}

		[HttpPost]
		public virtual async Task<IActionResult> Save(T entity)
		{
			await _service.SaveAsync(entity);
			return Ok();
		}
	}
}