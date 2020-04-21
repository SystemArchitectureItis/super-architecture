using System.Collections.Generic;
using System.Threading.Tasks;
using SystemArchitecture.Database;
using SystemArchitecture.Models.Entities.Base;

namespace SystemArchitecture.Core
{
	public class DomainService<T> where T : HaveId
	{
		private readonly ApplicationDbContext _context;

		public DomainService(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task DeleteAsync(long id)
		{
			var entity = await _context.Set<T>().FindAsync(id);
			if (entity != null)
				_context.Set<T>().Remove(entity);
			await Save();
		}

		public async Task<T> GetAsync(long entityId)
		{
			return await _context.Set<T>().FindAsync(entityId);
		}

		public async Task<IEnumerable<T>> GetAllAsync()
		{
			await Task.CompletedTask;
			return _context.Set<T>().AsQueryable();
		}

		public async Task SaveAsync(T entity)
		{
			await _context.Set<T>().AddAsync(entity);
			await Save();
		}

		public async Task UpdateAsync(T entity)
		{
			_context.Set<T>().Update(entity);
			await Save();
		}

		private async Task Save()
		{
			await _context.SaveChangesAsync();
		}
	}
}