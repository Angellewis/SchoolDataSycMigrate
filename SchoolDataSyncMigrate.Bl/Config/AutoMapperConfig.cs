using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDataSyncMigrate.Bl.Config
{
    public static class AutoMapperConfig
    {
        public static IServiceCollection ConfigAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return services;
        }
    }
}
