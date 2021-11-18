using AutoMapper;
using SchoolDataSyncMigrate.Bl.Dto;
using SchoolDataSyncMigrate.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDataSyncMigrate.Bl.Mapper
{
    public class MainMapperProfile : Profile
    {
        public MainMapperProfile()
        {
            CreateMap<NewUsers, NewUsersDto>();
            CreateMap<NewUsersDto, NewUsers>();

            CreateMap<NewCourse, NewCourseDto>();
            CreateMap<NewCourseDto, NewCourse>();
        }
    }
}
