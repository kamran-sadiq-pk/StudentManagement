using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.ViewModels
{
    public class CourseViewModel
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CreditHours { get; set; }
        public int Status { get; set; }
        public string Author { get; set; }
    }
}
