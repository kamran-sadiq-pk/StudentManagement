using StudentManagement.Businesslogic;
using StudentManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace StudentManagement.Controllers
{
    public class CMSController : Controller
    {
        // GET: CMS
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Admins()
        {
            return View();
        }

        public ActionResult Students()
        {
            return View();
        }

        public ActionResult Courses()
        {
            return View();
        }
        public ActionResult Invites()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SaveAdmin()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SaveCourse()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> SaveAdmin(AdminViewModel admin)
        {
            try
            {
                AccountBusinessLogic accountBusinessLogic = new AccountBusinessLogic();
                var result = await accountBusinessLogic.SaveAdminAsync(admin);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetAdminById(int id)
        {
            try
            {
                AccountBusinessLogic accountBusinessLogic = new AccountBusinessLogic();
                var result = await accountBusinessLogic.GetAdminByIdAsync(id);
                return Json(result.responseObject,JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<ActionResult> DeleteAdminById(int id)
        {
            try
            {
                AccountBusinessLogic accountBusinessLogic = new AccountBusinessLogic();
                var result = await accountBusinessLogic.DeleteAdminByIdAsync(id);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<ActionResult> ActiveInActiveStatusStudent(int studentId, int statusId)
        {
            try
            {
                StudentBusinessLogic studentBusinessLogic = new StudentBusinessLogic();
                var result = await studentBusinessLogic.ActiveInActiveStatusStudent(studentId, statusId);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetCourseById(int id)
        {
            try
            {
                CourseBusinessLogic courseBusinessLogic = new CourseBusinessLogic();
                var result = await courseBusinessLogic.GetCourseById(id);
                return Json(result.responseObject, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public async Task<ActionResult> SaveCourse(CourseViewModel courseViewModel)
        {
            try
            {
                CourseBusinessLogic courseBusinessLogic = new CourseBusinessLogic();
                var result = await courseBusinessLogic.SaveCourse(courseViewModel);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<ActionResult> DeleteCourseById(int id)
        {
            try
            {
                CourseBusinessLogic courseBusinessLogic = new CourseBusinessLogic();
                var result = await courseBusinessLogic.DeleteCourse(id);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public ActionResult StudentDetails(int id)
        {
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> GetStudentDetails(int id)
        {
            try
            {
                StudentBusinessLogic studentBusinessLogic = new StudentBusinessLogic();
                var result = await studentBusinessLogic.GetSudentDetails(id);
                return Json(result.responseObject, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}