using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDataSyncMigrate.Core.BaseModel
{
    public interface IBaseEntity : IBase
    {
        DateTimeOffset CreatedDate { get; set; }
    }
    public class BaseEntity : Base, IBaseEntity
    {
        public virtual DateTimeOffset CreatedDate { get; set; }
    }
}
