using SchoolDataSyncMigrate.Bl.Dto;
using SchoolDataSyncMigrate.Model.Entities;
using SchoolDataSyncMigrate.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDataSyncMigrate.Controllers
{
    public class UserController : BaseController<NewUsers, NewUsersDto>
    {
        public UserController(IUserService service) : base(service)
        {

        }
    }
}
