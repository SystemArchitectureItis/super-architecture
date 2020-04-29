using System;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SystemArchitecture.Web.Controllers.Base
{
	[Route("[action]")]
	public class SystemController : Controller
	{
		private readonly ILogger<SystemController> _logger;

		public SystemController(ILogger<SystemController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public IActionResult Ping()
		{
			return Ok("Online");
		}

		[ApiExplorerSettings(IgnoreApi = true)]
		[AcceptVerbs("GET", "POST", "PUT", "DELETE", "HEAD", "OPTIONS", "PATCH")]
		public IActionResult Error()
		{
			var handlerResult = HttpContext
				.Features
				.Get<IExceptionHandlerPathFeature>();

			if (handlerResult == null)
				return Conflict("Smth went wrong.");

			_logger.LogError(handlerResult.Error,
				$"Unhandled error on {handlerResult.Path}:{Environment.NewLine} {handlerResult.Error}");
			return Conflict(new
			{
				handlerResult.Error.Message,
				RequestPath = handlerResult.Path
			});
		}
	}
}