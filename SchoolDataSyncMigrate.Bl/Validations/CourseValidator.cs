using FluentValidation;
using SchoolDataSyncMigrate.Bl.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDataSyncMigrate.Bl.Validations
{
    public class CourseValidator : AbstractValidator<NewCourseDto>
    {
        public CourseValidator()
        {
            RuleFor(x => x.ShortName)
                .NotEmpty()
                .WithMessage("Name is required");
        }
    }
}
