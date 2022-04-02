using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Database.Models
{
    public class Invites
    {
        [Key]
        public int InviteId { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public DateTime SentDate { get; set; }
        public string InviteLink { get; set; }
        public int SentBy { get; set; }
        public int Status { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public Nullable<int> Updateby { get; set; }

    }
}
