using StudentManagement.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Businesslogic
{
    public class BusinessLogicBase
    {
        protected StudentManagementContext db = new StudentManagementContext();
    }
}
