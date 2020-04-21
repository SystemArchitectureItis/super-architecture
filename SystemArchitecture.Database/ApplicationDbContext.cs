using Microsoft.EntityFrameworkCore;
using SystemArchitecture.Models.Entities.Connectors;
using SystemArchitecture.Models.Entities;

namespace SystemArchitecture.Database
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext()
		{
		}

		public ApplicationDbContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql(ConnectionStrings.Current);
		}

		// entities
		public DbSet<Party> Parties { get; set; }
		public DbSet<Debt> Debts { get; set; }
		public DbSet<Purchase> Purchases { get; set; }
		public DbSet<User> Users { get; set; }
		
		// connectors
		public DbSet<UserDebtor> UserDebtors { get; set; }
		public DbSet<PartyUser> PartyUsers { get; set; }
	}
}