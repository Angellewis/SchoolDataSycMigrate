using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SchoolDataSyncMigrate.Model.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDataSyncMigrate.Bl.Config
{
    public static class SqlServerDbConfig
    {
        public static IServiceCollection ConfigSqlServerDbContext(this IServiceCollection services, string connection)
        {
            services.AddDbContext<SDSContext>(options => options.UseSqlServer(connection));

            return services;
        }
    }
}
