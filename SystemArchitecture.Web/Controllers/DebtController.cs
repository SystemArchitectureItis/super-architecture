using System.Threading.Tasks;
using SystemArchitecture.Core;
using SystemArchitecture.Models.Entities;
using SystemArchitecture.Web.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace SystemArchitecture.Web.Controllers
{
	public class DebtController : BaseController<Debt>
	{
		public DebtController(BaseDomainService<Debt> service) : base(service)
		{
		}

		public override async Task<IActionResult> Save(Debt entity)
		{
			// if (entity.Creditor?.Id != null && entity.Creditor.Id > 0)
			// 	entity.Creditor = await Service.GetAsync(entity.Creditor.Id);
			// if (entity.Debtor?.Id != null && entity.Debtor.Id > 0)
			// 	entity.Debtor = await Service.GetAsync(entity.Debtor.Id);
			return await base.Save(entity);
		}
	}
}