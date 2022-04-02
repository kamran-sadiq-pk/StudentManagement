using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Database.Models
{

    public  class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public Nullable<int> CreditHours { get; set; }
        public int Status { get; set; }
        public string Author { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public Nullable<int> Updatedby { get; set; }
        
    }
}
