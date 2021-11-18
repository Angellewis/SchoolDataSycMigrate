using SchoolDataSyncMigrate.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDataSyncMigrate.Bl.Dto
{
    public class NewCourseDto : BaseEntityDto
    {
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string Category { get; set; }
        public string School { get; set; }
        //------------------------------------------------
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
