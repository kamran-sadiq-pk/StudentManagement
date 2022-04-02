using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Database.Models
{
    public  class Status
    {
        public int StatusId { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public Nullable<int> Updatedby { get; set; }
    }
}
