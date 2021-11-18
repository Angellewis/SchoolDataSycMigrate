﻿using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNet.OData.Formatter;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;
using Microsoft.OData.Edm;
using SchoolDataSyncMigrate.Model.Entities;
using System.Linq;

namespace SchoolDataSyncMigrate.Config
{
    public static class OdataConfig
    {
        public static IServiceCollection ConfigOData(this IServiceCollection services)
        {
            services.AddOData();
            services.AddMvcCore(options =>
            {
                foreach (var outputFormatter in options.OutputFormatters.OfType<ODataOutputFormatter>().Where(_ => _.SupportedMediaTypes.Count == 0))
                {
                    outputFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/prs.odatatestxx-odata"));
                }
                foreach (var inputFormatter in options.InputFormatters.OfType<ODataInputFormatter>().Where(_ => _.SupportedMediaTypes.Count == 0))
                {
                    inputFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/prs.odatatestxx-odata"));
                }
            });

            return services;
        }


        public static IRouteBuilder UseAppOData(this IRouteBuilder builder)
        {
            builder.Select().Expand().Filter().OrderBy().MaxTop(100).Count();
            builder.MapODataServiceRoute("odata", "odata", GetEdmModel());
            builder.EnableDependencyInjection();

            return builder;
        }

        private static IEdmModel GetEdmModel()
        {
            var odataBuilder = new ODataConventionModelBuilder();

            //TODO: replace Entity with Dto when refactor Controller Get Method
            odataBuilder.EntitySet<NewUsers>("User");
            odataBuilder.EntitySet<NewCourse>("Course");

            return odataBuilder.GetEdmModel();
        }
    }
}
