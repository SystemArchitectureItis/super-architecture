using System;
using Microsoft.Extensions.DependencyInjection;
using SystemArchitecture.Core;
using SystemArchitecture.Core.EntityServices;
using SystemArchitecture.Core.EntityServices.Base;
using SystemArchitecture.Database;
using SystemArchitecture.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace SystemArchitecture.Web
{
	public static class StartupExtensions
	{
		public static void RegisterServices(this IServiceCollection services)
		{
			services.AddScoped(typeof(BaseDomainService<>));
			services.AddScoped<CardService>();
			services.AddScoped<UserService>();
			services.AddScoped<DebtService>();
			services.AddScoped<PurchaseService>();
			
			services.AddScoped<PasswordService>();
			
			services.AddScoped<IDataStore, DataStore>();
		}

		public static void SetConnectionString(this IServiceCollection services)
		{
			var connString = Environment.GetEnvironmentVariable("CONN_STRING");
			if (string.IsNullOrEmpty(connString))
				throw new ArgumentException("Не указана строка подключения.");
			ConnectionStrings.Current = connString;
		}
		
		public static void RegisterContext(this IServiceCollection services)
		{
			services.AddDbContext<ApplicationDbContext>(o =>
			{
				o.UseLazyLoadingProxies();
			});
			services.AddScoped<DbContext, ApplicationDbContext>();
		}

		public static void RunMigrations(this IServiceCollection services)
		{
			new ApplicationDbContext().Database.Migrate();
		}
	}
}