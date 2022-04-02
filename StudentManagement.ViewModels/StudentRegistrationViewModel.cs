using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.ViewModels
{
    public class StudentRegistrationViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
        public int CourseId { get; set; }

    }


    public class StudentListViewModel
    {
        public StudentListViewModel()
        {
            _list = new List<StudentRegistrationViewModel>();
        }
        public List<StudentRegistrationViewModel> _list { get; set; }
    }

    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int StatusId { get; set; }
    }
}
