using System;
using System.Threading.Tasks;
using SystemArchitecture.Core.EntityServices.Base;
using SystemArchitecture.Models;
using SystemArchitecture.Models.Entities;
using SystemArchitecture.Models.Infrastructure;

namespace SystemArchitecture.Core.EntityServices
{
	public class PurchaseService : BaseDomainService<Purchase>
	{
		public PurchaseService(IDataStore dataStore) : base(dataStore)
		{
		}

		public override async Task UpdateAsync(Purchase entity)
		{
			if (entity.Party == null)
				throw new ArgumentNullException(nameof(entity.Party), "Не указано мероприятие.");
			if (entity.Party.Id > 0)
			{
				var dbUser = await DataStore.GetAsync<Party>(entity.Party.Id);
				entity.Party = entity.Party.AsNewEntity(true, dbUser);
			}

			await base.UpdateAsync(entity);
		}
		
		public override async Task SaveAsync(Purchase entity)
		{
			if (entity.Party == null)
				throw new ArgumentNullException(nameof(entity.Party), "Не указано мероприятие.");
			if (entity.Party.Id > 0)
			{
				var dbUser = await DataStore.GetAsync<Party>(entity.Party.Id);
				entity.Party = entity.Party.AsNewEntity(true, dbUser);
			}

			await base.SaveAsync(entity);
		}
	}
}