using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using SchoolDataSyncMigrate.Bl.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDataSyncMigrate.Bl.Config
{
    public static class FluentValidationConfig
    {
        public static IMvcBuilder ConfigFluentValidation(this IMvcBuilder builder)
        {
            builder.AddFluentValidation(x =>
            {
                x.AutomaticValidationEnabled = false;
                x.RegisterValidatorsFromAssemblyContaining<UserValidator>();
            });
            return builder;
        }
    }
}
