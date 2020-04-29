using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SystemArchitecture.Models;
using SystemArchitecture.Models.Entities;
using SystemArchitecture.Models.Infrastructure;

namespace SystemArchitecture.Core
{
	public class CardService : BaseDomainService<BankCard>
	{
		public CardService(IDataStore dataStore) : base(dataStore)
		{
		}

		public override async Task SaveAsync(BankCard entity)
		{
			if (entity.CardHolder == null)
				throw new ArgumentNullException(nameof(entity.CardHolder), "Не указан держатель карты.");
			if (entity.CardHolder.Id > 0)
			{
				var dbUser = await DataStore.GetAsync<User>(entity.CardHolder.Id);
				entity.CardHolder = entity.CardHolder.AsNewEntity(true, dbUser);
			}

			await base.SaveAsync(entity);
		}
	}
}