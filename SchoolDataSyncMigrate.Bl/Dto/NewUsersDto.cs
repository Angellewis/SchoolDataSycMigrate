using SchoolDataSyncMigrate.Core.BaseModel;
using SchoolDataSyncMigrate.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDataSyncMigrate.Bl.Dto
{
    public class NewUsersDto : BaseEntityDto
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Course { get; set; }
        public UserRoles Role { get; set; }
    }
}
