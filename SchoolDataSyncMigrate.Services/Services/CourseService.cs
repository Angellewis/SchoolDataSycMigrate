using AutoMapper;
using FluentValidation;
using SchoolDataSyncMigrate.Bl.Dto;
using SchoolDataSyncMigrate.Model.Entities;
using SchoolDataSyncMigrate.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDataSyncMigrate.Services.Services
{
    public interface ICourseService : IBaseService<NewCourse, NewCourseDto> { }
    public class CourseService : BaseService<NewCourse, NewCourseDto>, ICourseService
    {
        public CourseService(
            ICourseRepository repository,
            IMapper mapper,
            IValidator<NewCourseDto> validator) : base(repository, mapper, validator)
        {
        }
    }
}
