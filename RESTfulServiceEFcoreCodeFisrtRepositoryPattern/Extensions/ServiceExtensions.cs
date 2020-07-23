using Contracts;
using Entities.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTfulServiceEFcoreCodeFisrtRepositoryPattern.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureMysqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            var ConnectionString = configuration["ConnectionStrings:mysqlconnection"];
            services.AddDbContext<RepositoryContext>(o => o.UseMySql(ConnectionString));
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

            // check if database not exist
            var serviceProvider = services.BuildServiceProvider();
            var context = serviceProvider.GetRequiredService<RepositoryContext>();
            context.Database.EnsureCreated();
        }


    }
}
