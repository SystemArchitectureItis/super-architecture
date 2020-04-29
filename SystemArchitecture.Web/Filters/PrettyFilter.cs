using SystemArchitecture.Models;
using SystemArchitecture.Models.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SystemArchitecture.Web.Filters
{
	public class PrettyFilter : ActionFilterAttribute
	{
		public override void OnActionExecuted(ActionExecutedContext context)
		{
			if (context.Exception != null)
			{
				context.Result = new OkObjectResult(Result.Failure(context.Exception.Message));
				context.ExceptionHandled = true;
				context.Exception = null;
			}
 
			if (context.Result is OkResult)
				context.Result = new OkObjectResult(Result.Successful());

			base.OnActionExecuted(context);
		}
	}
}