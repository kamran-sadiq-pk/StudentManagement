using StudentManagement.Database;
using StudentManagement.Database.Models;
using StudentManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Businesslogic
{
    public class AccountBusinessLogic : BusinessLogicBase
    {
        public async Task<GenericResponse> LoginAsync(LoginViewModel loginViewModel)
        {
            return await Task.Run(() =>
            {
                try
                {
                    GenericResponse genericResponse = new GenericResponse();
                    var user = db.Users.FirstOrDefault(c => c.Email == loginViewModel.Email && c.Password == loginViewModel.Password && c.Status == 1);

                    if (user == null)
                    {
                        genericResponse.FeedBack = "Incorrect email and password";
                        
                    }
                    else
                    {
                        genericResponse.responseObject = user;
                        genericResponse.Status = true;
                    }

                    return genericResponse;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                
            });
        }
        public async Task<GenericResponse> RegistrationAsync(StudentRegistrationViewModel registrationViewModel)
        {
            return await Task.Run(() =>
            {
                try
                {
                    GenericResponse response = new GenericResponse();
                    var model = new Student();
                    model.FirstName = registrationViewModel.FirstName;
                    model.LastName = registrationViewModel.LastName;
                    model.Email = registrationViewModel.Email;
                    model.Password = registrationViewModel.Password;
                    model.CourseId = registrationViewModel.CourseId;
                    model.RegistrationStatus = 3;
                    db.Students.Add(model);
                    db.SaveChanges();
                    response.FeedBack = "Save successfully";
                    response.Status = true;
                    return response;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            });
        }
        public bool UserInRole(int roleId, string roleName)
        {
            return db.Roles.Any(v => v.RoleId == roleId && v.RoleName == roleName);
        }
        public async Task<GenericResponse> SaveAdminAsync(AdminViewModel adminViewModel)
        {
            return await Task.Run(() =>
            {
                try
                {
                    GenericResponse response = new GenericResponse();
                    var model = adminViewModel.AdminId == 0 ? new User() : db.Users.FirstOrDefault(t => t.UserId == adminViewModel.AdminId);
                    model.UserId = adminViewModel.AdminId;
                    model.FirstName = adminViewModel.FirstName;
                    model.LastName = adminViewModel.LastName;
                    model.Email = adminViewModel.Email;
                    model.Password = "123456";
                    model.Status = adminViewModel.Status;
                    model.IsAdmin = true;
                    db.Entry(model).State = model.UserId == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    response.FeedBack = "Save successfully";
                    response.Status = true;
                    return response;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            });
        }

        public async Task<GenericResponse> GetAdminByIdAsync(int id)
        {
            return await Task.Run(() =>
            {
                try
                {
                    GenericResponse response = new GenericResponse();
                    var model = db.Users.Where(c => c.UserId == id).Select(c => new AdminViewModel() {
                        AdminId = c.UserId,
                        FirstName = c.FirstName,
                        LastName = c.LastName,
                        Email = c.Email,
                        Status = c.Status
                    }).ToList();
                    response.responseObject = model;
                    response.Status = true;
                    return response;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            });
        }

        public async Task<GenericResponse> DeleteAdminByIdAsync(int id)
        {
            return await Task.Run(() =>
            {
                try
                {
                    GenericResponse response = new GenericResponse();
                    var model = db.Users.FirstOrDefault(_ => _.UserId == id);
                    if (model == null)
                    {
                        response.FeedBack = "Record not found";
                        return response;
                    }
                    db.Users.Remove(model);
                    db.SaveChanges();
                    response.FeedBack = "Record has been deleted successfully";
                    response.Status = true;
                    return response;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            });
        }

        
    }
}
