using System;
using System.Linq;
using System.Threading.Tasks;
using SystemArchitecture.Models.Entities.Base;

namespace SystemArchitecture.Models
{
	public interface IDataStore
	{
		TEntity Get<TEntity>(long entityId)
			where TEntity : HaveId;

		Task<TEntity> GetAsync<TEntity>(long entityId)
			where TEntity : HaveId;

		IQueryable<TEntity> GetAll<TEntity>()
			where TEntity : HaveId;

		TEntity Create<TEntity>(TEntity entity)
			where TEntity : HaveId;

		TEntity CreateAndSave<TEntity>(TEntity entity)
			where TEntity : HaveId;

		Task<TEntity> CreateAsync<TEntity>(TEntity entity)
			where TEntity : HaveId;

		Task<TEntity> CreateAndSaveAsync<TEntity>(TEntity entity)
			where TEntity : HaveId;

		TEntity Update<TEntity>(TEntity entity)
			where TEntity : HaveId;

		TEntity UpdateAndSave<TEntity>(TEntity entity)
			where TEntity : HaveId;

		Task<TEntity> UpdateAndSaveAsync<TEntity>(TEntity entity)
			where TEntity : HaveId;

		void Delete<TEntity>(TEntity entity)
			where TEntity : HaveId;

		void DeleteAndSave<TEntity>(TEntity entity)
			where TEntity : HaveId;

		Task DeleteAndSaveAsync<TEntity>(TEntity entity)
			where TEntity : HaveId;

		Task DeleteAndSaveAsync<TEntity>(long id)
			where TEntity : HaveId;
		
		void SaveChanges();
		Task SaveChangesAsync();
		void InTransaction(Action action);
		Task InTransactionAsync(Func<Task> action);
	}
}