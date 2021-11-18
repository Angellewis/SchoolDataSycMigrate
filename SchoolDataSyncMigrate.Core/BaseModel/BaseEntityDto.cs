using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDataSyncMigrate.Core.BaseModel
{
    public interface IBaseEntityDto : IBaseDto
    {
        DateTimeOffset? CreatedDate { get; set; }
    }
    public class BaseEntityDto : BaseDto, IBaseEntityDto
    {
        public virtual DateTimeOffset? CreatedDate { get; set; }
    }
}
