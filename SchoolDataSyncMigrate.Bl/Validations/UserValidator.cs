using FluentValidation;
using SchoolDataSyncMigrate.Bl.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDataSyncMigrate.Bl.Validations
{
    public class UserValidator : AbstractValidator<NewUsersDto>
    {
        public UserValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email Address is required");
        }
    }
}
