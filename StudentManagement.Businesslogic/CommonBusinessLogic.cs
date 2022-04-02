using StudentManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Businesslogic
{

   
    public class CommonBusinessLogic : BusinessLogicBase
    {

        /// <summary>
        /// These are the methods that will be frequently use in application's different modules;
        /// To speed up things i am fetching all records from tables. 
        /// in actual project we should paginate, sort, filter data using stored procedure or linq
        /// </summary>


        public async Task<GenericResponse> GetCoursesAsync()
        {
            return await Task.Run(() => {
                try
                {
                    GenericResponse response = new GenericResponse();
                    var courses = db.Courses.Where(c => c.Status == 1).ToList();
                    response.Status = true;
                    response.responseObject = courses;
                    return response;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            });
        }
        public async Task<GenericResponse> GetAdminsAsync()
        {
            return await Task.Run(() => {
                try
                {
                    GenericResponse response = new GenericResponse();
                    var admins = db.Users.Where(c => c.IsAdmin == true).ToList();
                    response.Status = true;
                    response.responseObject = admins;
                    return response;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            });
        }
        public async Task<GenericResponse> GetStudentsAsync()
        {
            return await Task.Run(() => {
                try
                {
                    GenericResponse response = new GenericResponse();
                    var students = (from student in db.Students
                                  join course in db.Courses
                                  on student.CourseId equals course.CourseId select new StudentViewModel
                                  {
                                      StudentId = student.StudentId,
                                      FirstName = student.FirstName,
                                      LastName = student.LastName,
                                      Email = student.Email,
                                      CourseId = student.CourseId.Value,
                                      CourseName = course.CourseName,
                                      Status = db.Statuses.FirstOrDefault(b => b.StatusId == student.RegistrationStatus).Name,
                                      StatusId = student.RegistrationStatus
                                  }).ToList();
                    response.Status = true;
                    response.responseObject = students;
                    return response;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            });
        }
        public async Task<GenericResponse> GetInvitesAsync()
        {
            return await Task.Run(() => {
                try
                {
                    GenericResponse response = new GenericResponse();
                    var invites = db.Invites.ToList();
                    response.Status = true;
                    response.responseObject = invites;
                    return response;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            });
        }
        public async Task<GenericResponse> GetStatusAsync()
        {
            return await Task.Run(() => {
                try
                {
                    GenericResponse response = new GenericResponse();
                    var statuses = db.Statuses.ToList();
                    response.Status = true;
                    response.responseObject = statuses;
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
