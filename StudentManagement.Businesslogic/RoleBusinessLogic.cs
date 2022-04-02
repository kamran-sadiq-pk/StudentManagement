using StudentManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Businesslogic
{
    public class RoleBusinessLogic : BusinessLogicBase
    {
        /// <summary>
        /// Make application left menu base on permission given to user.
        /// Logged in user will only see those left menu item those were assigned.
        /// </summary>
        /// <returns></returns>
        public async Task<GenericResponse> GetRoleEntitlements(int userId)
        {
            return await Task.Run(() => { return new GenericResponse(); });
        }

    }
}
