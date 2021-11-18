using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SchoolDataSyncMigrate.Bl.Config;
using SchoolDataSyncMigrate.Config;
using SchoolDataSyncMigrate.Model.IoC;
using SchoolDataSyncMigrate.Services.IoC;

namespace SchoolDataSyncMigrate
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            #region CORS

            services.AddCors(options =>
            {
                options.AddPolicy("MainPolicy",
                      builder =>
                      {
                          builder
                                 .AllowAnyHeader()
                                 .AllowAnyMethod()
                                 .AllowCredentials();

                          //TODO: remove this line for production
                          builder.SetIsOriginAllowed(x => true);
                      });
            });

            #endregion

            #region External Dependencies

            services.ConfigSqlServerDbContext(Configuration.GetConnectionString("DefaultConnection"));
            services.AddControllers(options => options.EnableEndpointRouting = false).ConfigFluentValidation();
            services.ConfigAutoMapper();
            services.ConfigSerilog();

            #endregion

            #region API Libraries

            services.ConfigOData();
            services.ConfigSwagger();

            #endregion

            #region App Registries

            services.AddModelRegistry();
            services.AddServiceRegistry();

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAppSwagger();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors("MainPolicy");

            app.UseMvc(routeBuilder => routeBuilder.UseAppOData());
        }
    }
}
