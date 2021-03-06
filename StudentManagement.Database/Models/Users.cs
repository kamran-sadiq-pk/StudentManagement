using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Database.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<bool> IsSuperAdmin { get; set; }
        public Nullable<bool> IsAdmin { get; set; }
        public Nullable<int> RoleId { get; set; }
        public int Status { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public Nullable<int> Updatedby { get; set; }
        
    }
}
