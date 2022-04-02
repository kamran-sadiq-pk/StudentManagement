using StudentManagement.Database.Models;
using StudentManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Businesslogic
{
    public class CourseBusinessLogic : BusinessLogicBase
    {
        public async Task<GenericResponse> SaveCourse(CourseViewModel courseViewModel)
        {
            return await Task.Run(() => {
                GenericResponse response = new GenericResponse();
                try
                {
                   
                    var model = courseViewModel.CourseId == 0 ? new Course() : db.Courses.FirstOrDefault(v => v.CourseId == courseViewModel.CourseId);
                    model.CourseId = courseViewModel.CourseId;
                    model.CourseName = courseViewModel.CourseName;
                    model.Author = courseViewModel.Author;
                    model.CreditHours = courseViewModel.CreditHours;
                    model.Status = courseViewModel.Status;
                    db.Entry(model).State = courseViewModel.CourseId == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    response.FeedBack = "Save successfully";
                    response.Status = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return response;
            });
        }
        public async Task<GenericResponse> GetCourseById(int courseId)
        {
            return await Task.Run(() => {
                GenericResponse response = new GenericResponse();
                try
                {
                    var model = db.Courses.FirstOrDefault(v => v.CourseId == courseId);
                    response.responseObject = model;
                    
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return response;
            });
        }
        public async Task<GenericResponse> DeleteCourse(int courseId)
        {
            return await Task.Run(() => {
                GenericResponse response = new GenericResponse();
                try
                {
                    var model = db.Courses.FirstOrDefault(w => w.CourseId == courseId);
                    db.Courses.Remove(model);
                    db.SaveChanges();
                    response.FeedBack = "Deleted successfully";
                    response.Status = true;
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
