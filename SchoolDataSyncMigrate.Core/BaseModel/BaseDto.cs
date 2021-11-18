using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDataSyncMigrate.Core.BaseModel
{
    public interface IBaseDto
    {
        int? Id { get; set; }
    }
    public class BaseDto : IBaseDto
    {
        public virtual int? Id { get; set; }
    }
}
