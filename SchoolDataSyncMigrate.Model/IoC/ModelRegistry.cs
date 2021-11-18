using Microsoft.Extensions.DependencyInjection;
using SchoolDataSyncMigrate.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDataSyncMigrate.Model.IoC
{
    public static class ModelRegistry
    {
        public static void AddModelRegistry(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
