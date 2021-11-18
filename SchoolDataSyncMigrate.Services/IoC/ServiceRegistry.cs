using Microsoft.Extensions.DependencyInjection;
using SchoolDataSyncMigrate.Services.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDataSyncMigrate.Services.IoC
{
    public static class ServiceRegistry
    {
        public static void AddServiceRegistry(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICourseService, CourseService>();
        }
    }
}
