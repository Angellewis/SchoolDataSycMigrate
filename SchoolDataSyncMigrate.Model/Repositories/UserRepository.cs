using SchoolDataSyncMigrate.Model.Contexts;
using SchoolDataSyncMigrate.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDataSyncMigrate.Model.Repositories
{
    public interface IUserRepository : IBaseRepository<NewUsers> { }
    public class UserRepository : BaseRepository<NewUsers>, IUserRepository
    {
        public UserRepository(SDSContext context) : base(context)
        {
        }
    }
}
