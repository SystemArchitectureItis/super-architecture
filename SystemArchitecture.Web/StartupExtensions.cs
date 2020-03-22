﻿using Microsoft.Extensions.DependencyInjection;
using SystemArchitecture.Core;
using SystemArchitecture.Database;

namespace SystemArchitecture.Web
{
	public static class StartupExtensions
	{
		public static void RegisterServices(this IServiceCollection services)
		{
			services.AddSingleton(typeof(DomainService<>));
		}

		public static void RegisterContext(this IServiceCollection services)
		{
			services.AddDbContext<ApplicationDbContext>();
		}
	}
}