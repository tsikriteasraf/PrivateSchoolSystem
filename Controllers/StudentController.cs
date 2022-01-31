using PrivateScoolSystem.Views;
using PrivateScoolSystem.Views.Validations;
using System;
using System.Linq;

namespace PrivateScoolSystem.Controllers
{
   internal class StudentController:Controller
    {
        public void ReadAllStudents() => ViewStudent.PrintAll(unitOfWork.Students.GetAll());
        public void ReadStudentsPerCourse() => ViewStudent.PrintStudentsPerCourse(unitOfWork.Courses.GetStudentsPerCourse());
        public void ReadStudentsMoreCourses() => ViewStudent.PrintStudentMoreCourses(unitOfWork.Students.GetAStudentWithMultiCourses());
        public  void CreateStudent()
        {
                var student = ViewStudent.CreateInputStudent();
                unitOfWork.Students.Add(student);
                unitOfWork.Complete();
        }
        public void AttachStudentToCourse(int studentId, int courseId)
        {
                var student = unitOfWork.Students.Get(studentId);
                var course = unitOfWork.Courses.Get(courseId);
                course.Students.Add(student);
                student.Courses.Add(course);
                unitOfWork.Complete();
        }
        public void AssignStudentToCourse()
        {
            var courseController = new CourseController();
            var students = unitOfWork.Students.GetAll();
            Console.WriteLine(@"Assign Student To Course");
            ReadAllStudents();

            courseController.ReadAllCourses();

            var studentId = Validation.IsValidLinkingStudent(unitOfWork.Students.GetAll());

            var courseId = Validation.IsValidLinkingCourse(unitOfWork.Courses.GetAll());

            AttachStudentToCourse(studentId, courseId);
        }
        public void UpdateStudent()
        {
                ReadAllStudents();
                var studentId = Validation.IsValidLinkingStudent(unitOfWork.Students.GetAll());
                var studentNew = ViewStudent.CreateInputStudent();
                var student = unitOfWork.Students.Find(x => x.Id == studentId).First();
                student.FirstName= studentNew.FirstName;
                student.LastName= studentNew.LastName;  
                student.DateOfBirth=studentNew.DateOfBirth;
                student.TuitionFees= studentNew.TuitionFees;
                unitOfWork.Students.ModifyEntity(student);
                unitOfWork.Complete();
        }
        public void DeleteStudent()
        {
                ReadAllStudents();
                var studentId = Validation.IsValidLinkingStudent(unitOfWork.Students.GetAll());
                var student = unitOfWork.Students.Find(x => x.Id == studentId).First();
                unitOfWork.Students.Remove(student);
                unitOfWork.Complete();
        }
    }
}
