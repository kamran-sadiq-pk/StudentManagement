using StudentManagement.Database.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Database
{
    public class StudentManagementContext : DbContext
    {
        public StudentManagementContext() 
            : base("name=StudentManagementEntities")
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Invites> Invites { get; set; }

    }
}
