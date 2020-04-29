using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SystemArchitecture.Models;
using SystemArchitecture.Models.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace SystemArchitecture.Database
{
	public class DataStore : IDataStore
	{
		private readonly DbContext _dbContext;

		public DataStore(DbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public TEntity Get<TEntity>(long entityId) where TEntity : HaveId
		{
			return _dbContext.Set<TEntity>().Find(entityId);
		}

		public async Task<TEntity> GetAsync<TEntity>(long entityId) where TEntity : HaveId
		{
			return await _dbContext.Set<TEntity>().FindAsync(entityId);
		}

		public IQueryable<TEntity> GetAll<TEntity>() where TEntity : HaveId
		{
			return _dbContext.Set<TEntity>().AsQueryable();
		}

		public TEntity Create<TEntity>(TEntity entity) where TEntity : HaveId
		{
			_dbContext.Add(entity);
			return entity;
		}

		public TEntity CreateAndSave<TEntity>(TEntity entity) where TEntity : HaveId
		{
			_dbContext.Add(entity);
			_dbContext.SaveChanges();
			return entity;
		}

		public async Task<TEntity> CreateAsync<TEntity>(TEntity entity) where TEntity : HaveId
		{
			await _dbContext.AddAsync(entity);
			return entity;
		}

		public async Task<TEntity> CreateAndSaveAsync<TEntity>(TEntity entity) where TEntity : HaveId
		{
			await _dbContext.AddAsync(entity);
			await _dbContext.SaveChangesAsync();
			return entity;
		}

		public TEntity Update<TEntity>(TEntity entity) where TEntity : HaveId
		{
			_dbContext.Update(entity);
			return entity;
		}

		public TEntity UpdateAndSave<TEntity>(TEntity entity) where TEntity : HaveId
		{
			_dbContext.Update(entity);
			_dbContext.SaveChanges();
			return entity;
		}

		public async Task<TEntity> UpdateAndSaveAsync<TEntity>(TEntity entity) where TEntity : HaveId
		{
			_dbContext.Update(entity);
			await _dbContext.SaveChangesAsync();
			return entity;
		}

		public void Delete<TEntity>(TEntity entity) where TEntity : HaveId
		{
			_dbContext.Remove(entity);
		}

		public void DeleteAndSave<TEntity>(TEntity entity) where TEntity : HaveId
		{
			_dbContext.Remove(entity);
			_dbContext.SaveChanges();
		}

		public async Task DeleteAndSaveAsync<TEntity>(TEntity entity) where TEntity : HaveId
		{
			_dbContext.Remove(entity);
			await _dbContext.SaveChangesAsync();
		}

		public async Task DeleteAndSaveAsync<TEntity>(long id) where TEntity : HaveId
		{
			var entity = await _dbContext.Set<TEntity>().FindAsync(id);
			if (entity != null)
				_dbContext.Set<TEntity>().Remove(entity);
			await _dbContext.SaveChangesAsync();
		}

		public void SaveChanges()
		{
			_dbContext.SaveChanges();
		}

		public async Task SaveChangesAsync()
		{
			await _dbContext.SaveChangesAsync();
		}

		public void InTransaction(Action action)
		{
			try
			{
				action();
				SaveChanges();
			}
			catch
			{
				throw new ValidationException("Ошибка транзакции");
			}
		}

		public async Task InTransactionAsync(Func<Task> action)
		{
			try
			{
				await action();
				await SaveChangesAsync();
			}
			catch
			{
				throw new ValidationException("Ошибка транзакции");
			}
		}
	}
}