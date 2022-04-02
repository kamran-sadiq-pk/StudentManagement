using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.ViewModels
{
    public class GenericResponse
    {
        public bool Status { get; set; }
        public string FeedBack { get; set; }
        public object responseObject { get; set; }
    }
}
