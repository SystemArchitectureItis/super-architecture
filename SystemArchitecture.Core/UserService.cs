using System.Threading.Tasks;
using SystemArchitecture.Models;
using SystemArchitecture.Models.Entities;

namespace SystemArchitecture.Core
{
	public class UserService : BaseDomainService<User>
	{
		private readonly PasswordService _passwordService;

		public UserService(IDataStore dataStore, PasswordService passwordService) : base(dataStore)
		{
			_passwordService = passwordService;
		}

		public override Task UpdateAsync(User entity)
		{
			if (!string.IsNullOrWhiteSpace(entity.Password))
				entity.Password = _passwordService.HashPassword(entity.Password);

			return base.UpdateAsync(entity);
		}

		public override Task SaveAsync(User entity)
		{
			if (!string.IsNullOrWhiteSpace(entity.Password))
				entity.Password = _passwordService.HashPassword(entity.Password);
			
			return base.SaveAsync(entity);
		}
	}
}