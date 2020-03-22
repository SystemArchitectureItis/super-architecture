using System.Threading.Tasks;
using SystemArchitecture.Database;
using SystemArchitecture.Models.Entities.Base;

namespace SystemArchitecture.Core
{
	public class DomainService<T> where T : BaseEntity
	{
		private readonly ApplicationDbContext _context;

		public DomainService(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task DeleteAsync(long id)
		{
			await Task.CompletedTask;
			throw new System.NotImplementedException();
		}

		public async Task<T> GetAsync(long entityId)
		{
			await Task.CompletedTask;
			throw new System.NotImplementedException();
		}

		public async Task<T> GetAllAsync()
		{
			await Task.CompletedTask;
			throw new System.NotImplementedException();
		}

		public async Task SaveAsync(T entity)
		{
			await Task.CompletedTask;
			throw new System.NotImplementedException();
		}

		public async Task UpdateAsync(T entity)
		{
			await Task.CompletedTask;
			throw new System.NotImplementedException();
		}
	}
}