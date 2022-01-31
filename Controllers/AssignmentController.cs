using PrivateScoolSystem.Views;
using PrivateScoolSystem.Views.Validations;
using System;
using System.Linq;

namespace PrivateScoolSystem.Controllers
{
   internal class AssignmentController : Controller
    {
        public void ReadAllAssignments() => ViewAssignment.PrintAll(unitOfWork.Assignments.GetAll());
        public void ReadAllAssignmentsPerCourse() => ViewAssignment.PrintAssignmentsPerCourse(unitOfWork.Assignments.GetAssignmentsPerCourse());
        public void ReadAllAssignmentsPerStudent() => ViewAssignment.PrintAssignmentsPerStudent(unitOfWork.Students.GetAssignmentsPerStudent());
        public void ReadAllStudentsWithAssignmentsAt() => ViewAssignment.PrintAllStudentsWithAssignmentAtDate(Validation.IsValidSpecifiedDate(unitOfWork.Assignments.GetAll()), unitOfWork.Courses.GetAll());
        public void CreateAssignment()
        {
            var assignment = ViewAssignment.CreateInputAssignment();
            unitOfWork.Assignments.Add(assignment);
            unitOfWork.Complete();
        }
        public void AttachAssignmentToCourse(int assignmentId, int courseId)
        {
            var assignment = unitOfWork.Assignments.Get(assignmentId);
            unitOfWork.Assignments.Add(assignment);
            unitOfWork.Complete();
        }
        public void AssignAssignmentToCourse()
        {
            var courseController = new CourseController();
            Console.WriteLine(@"Assign Assignment To Course");
            ReadAllAssignments();

            courseController.ReadAllCourses();

            var assignmentId = Validation.IsValidLinkingAssignment(unitOfWork.Assignments.GetAll());

            var courseId = Validation.IsValidLinkingCourse(unitOfWork.Courses.GetAll());

            AttachAssignmentToCourse(assignmentId, courseId);
        }
        public void UpdateAssignment()
        {
            ReadAllAssignments();
            var assignmentId = Validation.IsValidLinkingAssignment(unitOfWork.Assignments.GetAll());
            var assignmentNew = ViewAssignment.CreateInputAssignment();
            var assignment = unitOfWork.Assignments.Find(x => x.Id == assignmentId).First();
            assignment.Title = assignmentNew.Title;
            assignment.Description = assignmentNew.Description;
            assignment.SubDateTime = assignmentNew.SubDateTime;
            assignment.TotalMark = assignmentNew.TotalMark;
            assignment.OralMark = assignmentNew.OralMark;
            unitOfWork.Complete();
        }
        public void DeleteAssignment()
        {
            ReadAllAssignments();
            var assignmentId = Validation.IsValidLinkingAssignment(unitOfWork.Assignments.GetAll());
            var assignment = unitOfWork.Assignments.Find(x => x.Id == assignmentId).First();
            unitOfWork.Assignments.Remove(assignment);
            unitOfWork.Assignments.ModifyEntity(assignment);
            unitOfWork.Complete();
        }
    }
}
