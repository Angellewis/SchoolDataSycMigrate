using Microsoft.EntityFrameworkCore;
using SchoolDataSyncMigrate.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDataSyncMigrate.Model.Contexts
{
    public class SDSContext : BaseDbContext
    {
        public SDSContext(DbContextOptions<SDSContext> options) : base(options)
        {

        }

        public DbSet<NewCourse> Courses { get; set; }
        public DbSet<NewUsers> Users { get; set; }
    }
}
