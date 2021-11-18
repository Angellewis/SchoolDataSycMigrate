﻿using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDataSyncMigrate.Bl.Config
{
    public static class SerilogConfig
    {
        public static IServiceCollection ConfigSerilog(this IServiceCollection services)
        {
            var _loggerConfig = new LoggerConfiguration().Enrich.FromLogContext();

            _loggerConfig
             .WriteTo.Logger(x => x.Filter.ByIncludingOnly(e => e.Level == Serilog.Events.LogEventLevel.Warning).WriteTo.File("C:/temp/SchoolDataSyncMigrate/logs/warnings.txt"))
             .WriteTo.Logger(x => x.Filter.ByIncludingOnly(e => e.Level == Serilog.Events.LogEventLevel.Error).WriteTo.File("C:/temp/SchoolDataSyncMigrate/logs/errors.txt"))
             .WriteTo.Logger(x => x.Filter.ByIncludingOnly(e => e.Level == Serilog.Events.LogEventLevel.Fatal).WriteTo.File("C:/temp/SchoolDataSyncMigrate/logs/fatals.txt"));

            Log.Logger = _loggerConfig.CreateLogger();

            services.AddSingleton(Log.Logger);

            return services;
        }
    }
}
