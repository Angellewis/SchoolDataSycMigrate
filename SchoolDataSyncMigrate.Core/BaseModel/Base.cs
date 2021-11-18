using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDataSyncMigrate.Core.BaseModel
{
    public interface IBase
    {
        int Id { get; set; }
    }
    public class Base : IBase
    {
        public virtual int Id { get; set; }
    }
}
