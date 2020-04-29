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
			optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=arch;Username=postgres;Password=postgres;");
			// optionsBuilder.UseNpgsql(ConnectionStrings.Current);	
		}

		public DbSet<BankCard> Cards { get; set; }
		public DbSet<Debt> Debts { get; set; }
		public DbSet<Location> Locations { get; set; }
		public DbSet<Party> Parties { get; set; }
		public DbSet<Purchase> Purchases { get; set; }
		public DbSet<User> Users { get; set; }
		
		
		public DbSet<PartyUser> PartyUsers { get; set; }
		public DbSet<PartyLocation> PartyLocations { get; set; }
	}
}