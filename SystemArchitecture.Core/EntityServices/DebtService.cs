using System;
using System.Threading.Tasks;
using SystemArchitecture.Core.EntityServices.Base;
using SystemArchitecture.Models;
using SystemArchitecture.Models.Entities;
using SystemArchitecture.Models.Infrastructure;

namespace SystemArchitecture.Core.EntityServices
{
	public class DebtService : BaseDomainService<Debt>
	{
		public DebtService(IDataStore dataStore) : base(dataStore)
		{
		}

		public override async Task UpdateAsync(Debt entity)
		{
			if (entity.Creditor == null)
				throw new ArgumentNullException(nameof(entity.Creditor), "Не указан получатель долга.");
			if (entity.Creditor.Id > 0)
			{
				var dbUser = await DataStore.GetAsync<User>(entity.Creditor.Id);
				entity.Creditor = entity.Creditor.AsNewEntity(true, dbUser);
			}
			if (entity.Debtor == null)
				throw new ArgumentNullException(nameof(entity.Debtor), "Не указан должник.");
			if (entity.Debtor.Id > 0)
			{
				var dbUser = await DataStore.GetAsync<User>(entity.Debtor.Id);
				entity.Debtor = entity.Debtor.AsNewEntity(true, dbUser);
			}

			await base.UpdateAsync(entity);
		}
		
		public override async Task SaveAsync(Debt entity)
		{
			if (entity.Creditor == null)
				throw new ArgumentNullException(nameof(entity.Creditor), "Не указан получатель долга.");
			if (entity.Creditor.Id > 0)
			{
				var dbUser = await DataStore.GetAsync<User>(entity.Creditor.Id);
				entity.Creditor = entity.Creditor.AsNewEntity(true, dbUser);
			}
			if (entity.Debtor == null)
				throw new ArgumentNullException(nameof(entity.Debtor), "Не указан должник.");
			if (entity.Debtor.Id > 0)
			{
				var dbUser = await DataStore.GetAsync<User>(entity.Debtor.Id);
				entity.Debtor = entity.Debtor.AsNewEntity(true, dbUser);
			}

			await base.SaveAsync(entity);
		}
	}
}