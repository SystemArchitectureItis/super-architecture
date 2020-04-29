using System.Collections.Generic;
using System.Threading.Tasks;
using SystemArchitecture.Models;
using SystemArchitecture.Models.Entities.Base;

namespace SystemArchitecture.Core
{
	public class BaseDomainService<T> where T : HaveId
	{
		protected readonly IDataStore DataStore;

		public BaseDomainService(IDataStore dataStore)
		{
			DataStore = dataStore;
		}

		public async Task DeleteAsync(long id) 
		{
			await DataStore.DeleteAndSaveAsync<T>(id);
		}

		public async Task<T> GetAsync(long entityId)
		{
			return await DataStore.GetAsync<T>(entityId);
		}

		public async Task<IEnumerable<T>> GetAllAsync()
		{
			await Task.CompletedTask;
			return DataStore.GetAll<T>();
		}

		public virtual async Task SaveAsync(T entity)
		{
			await DataStore.CreateAndSaveAsync(entity);
		}

		public virtual async Task UpdateAsync(T entity)
		{
			await DataStore.UpdateAndSaveAsync(entity);
		}
	}
}