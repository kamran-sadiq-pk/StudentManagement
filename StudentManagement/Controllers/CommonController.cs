using StudentManagement.Businesslogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace StudentManagement.Controllers
{
    public class CommonController : Controller
    {
        // GET: Common

        private CommonBusinessLogic commonBusinessLogic;
        public CommonController()
        {
            commonBusinessLogic = new CommonBusinessLogic();
        }
        [HttpGet]
        public async Task<JsonResult> GetCourses()
        {
            try
            {
                var courses = await commonBusinessLogic.GetCoursesAsync();
                return Json(courses.responseObject, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        [HttpGet]
        public async Task<JsonResult> GetAdmins()
        {
            try
            {
                var admins = await commonBusinessLogic.GetAdminsAsync();
                return Json(admins.responseObject, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpGet]
        public async Task<JsonResult> GetStudents()
        {
            try
            {
                var students = await commonBusinessLogic.GetStudentsAsync();
                return Json(students.responseObject, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpGet]
        public async Task<JsonResult> GetInvites()
        {
            try
            {
                var invites = await commonBusinessLogic.GetInvitesAsync();
                return Json(invites.responseObject, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpGet]
        public async Task<JsonResult> GetStatus()
        {
            try
            {
                var statuses = await commonBusinessLogic.GetStatusAsync();
                return Json(statuses.responseObject, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}