using PrivateScoolSystem.Views;
using PrivateScoolSystem.Views.Validations;
using System.Linq;

namespace PrivateScoolSystem.Controllers
{
   internal class CourseController : Controller
    {

        public void ReadAllCourses() => ViewCourse.PrintAll(unitOfWork.Courses.GetAll());
        public void CreateCourse()
        {

            var course = ViewCourse.CreateInputCourse();
            unitOfWork.Courses.Add(course);
            unitOfWork.Complete();
        }
        public void UpdateCourse()
        {
            ReadAllCourses();
            var courseId = Validation.IsValidLinkingCourse(unitOfWork.Courses.GetAll());
            var courseNew = ViewCourse.CreateInputCourse();
            var course = unitOfWork.Courses.Find(x => x.Id == courseId).First();
            course.Title = courseNew.Title;
            course.Stream = courseNew.Stream;
            course.Type = courseNew.Type;
            course.Start_Date = courseNew.Start_Date;
            course.End_Date = courseNew.End_Date;
            unitOfWork.Courses.ModifyEntity(course);
            unitOfWork.Complete();
        }
        public void DeleteCourse()
        {
            ReadAllCourses();
            var courseId = Validation.IsValidLinkingCourse(unitOfWork.Courses.GetAll());
            var course = unitOfWork.Courses.Find(x => x.Id == courseId).First();
            course.Assignments.Clear();
            unitOfWork.Courses.Remove(course);
            unitOfWork.Complete();
        }
    }
}
