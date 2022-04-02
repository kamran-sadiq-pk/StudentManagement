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
    public class AccountController : Controller
    {
        // GET: Account

        private AccountBusinessLogic accountBusinessLogic;
        public AccountController()
        {
           this.accountBusinessLogic = new AccountBusinessLogic();
        }
        public async Task<ActionResult> Index()
        {
            return await Task.Run(() => { return View(); });
        }

        [HttpGet]
        public async Task<ActionResult> Login()
        {
            return await Task.Run(() => { return View(); });
        }

        [HttpGet]
        public async Task<ActionResult> Registration()
        {
            return await Task.Run(() => { return View(); });
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel loginViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await accountBusinessLogic.LoginAsync(loginViewModel);
                    if (result.Status)
                    {
                        dynamic user = result.responseObject;
                        if (accountBusinessLogic.UserInRole(user.RoleId, "Superadmin")  || accountBusinessLogic.UserInRole(user.RoleId, "Admin"))
                        {
                           return RedirectToAction("Dashboard", "CMS");
                        }
                        if (accountBusinessLogic.UserInRole(user.RoleId, "Student"))
                        {
                            return RedirectToAction("StudentProfile", "Student");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(nameof(loginViewModel.ErrorMessage), result.FeedBack);
                        return View(loginViewModel);
                    }
                }

                return View(loginViewModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        [HttpPost]
        public async Task<ActionResult> Registration(StudentRegistrationViewModel student)
        {
            if (ModelState.IsValid)
            {
                var result = await accountBusinessLogic.RegistrationAsync(student);
                if (result.Status)
                {
                    return Json(result, JsonRequestBehavior.AllowGet);
                }
            }
            return View(student);
        }

        
    }
}