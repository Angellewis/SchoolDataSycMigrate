using SchoolDataSyncMigrate.Model.Contexts;
using SchoolDataSyncMigrate.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDataSyncMigrate.Model.Repositories
{
    public interface ICourseRepository : IBaseRepository<NewCourse> { }
    public class CourseRepository : BaseRepository<NewCourse>, ICourseRepository
    {
        public CourseRepository(SDSContext context) : base(context)
        {
        }
    }
}
