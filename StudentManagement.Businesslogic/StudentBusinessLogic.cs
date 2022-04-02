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
    public class StudentBusinessLogic : BusinessLogicBase
    {
        /// <summary>
        /// Verify status of student and allow student to login to system 
        /// 
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="statusId"></param>
        /// <returns></returns>
        public async Task<GenericResponse> ActiveInActiveStatusStudent(int studentId, int statusId)
        {
            return await Task.Run(() => {
                using (var context = new StudentManagementContext())
                {
                    using (var dbcontextTransaction = context.Database.BeginTransaction())
                    {
                        GenericResponse response = new GenericResponse();
                        try
                        {
                            var student = context.Students.FirstOrDefault(c => c.StudentId == studentId);
                            if (student.RegistrationStatus == 3)
                            {
                                if (!context.Users.Any(c => c.Email == student.Email))
                                {
                                    var user = new User();
                                    user.FirstName = student.FirstName;
                                    user.LastName = student.LastName;
                                    user.Email = student.Email;
                                    user.Password = student.Password;
                                    user.RoleId = context.Roles.FirstOrDefault(v => v.RoleName == "Student").RoleId;
                                    user.Status = 1; // Active;
                                    student.RegistrationStatus = 1; // Active;
                                    context.Users.Add(user);
                                    context.SaveChanges();

                                    dbcontextTransaction.Commit();
                                    response.Status = true;
                                    response.FeedBack = "Save successfully";
                                }
                                else
                                {
                                    response.Status = false;
                                    response.FeedBack = "User with same email already exist";
                                }
                            }                          
                        }
                        catch (Exception ex)
                        {
                            dbcontextTransaction.Rollback();
                            throw ex;
                        }
                        return response;
                    }
                }
            });
        }

        /// <summary>
        /// Send an invite to student 
        /// here we will configure third party email service like sendgrid etc. 
        /// student will receive email of invitation of registration to the site
        /// </summary>
        /// <returns></returns>
        public async Task<GenericResponse> SendInvitation(StudentInviteViewModel studentInviteViewModel )
        {
            return await Task.Run(() => { return new GenericResponse(); });
        }

        public async Task<GenericResponse> GetSudentDetails(int studentid)
        {
            return await Task.Run(() => {
                GenericResponse response = new GenericResponse();
                try
                {
                    var student = (from std in db.Students
                                   join course in db.Courses on std.CourseId equals course.CourseId
                                   join st in db.Statuses on std.RegistrationStatus equals st.StatusId
                                   select new StudentViewModel()
                                   {
                                       StudentId = std.StudentId,
                                       FirstName = std.FirstName,
                                       LastName = std.LastName,
                                       Email = std.Email,
                                       CourseName = course.CourseName,
                                       Status = st.Name,
                                       StatusId = st.StatusId

                                   }).Where(p => p.StudentId == studentid).FirstOrDefault();
                    response.responseObject = student;
                     
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return response;
            });
        }
    }
}
