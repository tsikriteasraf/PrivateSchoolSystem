using PrivateScoolSystem.Entities;
using System.Collections.Generic;

namespace PrivateScoolSystem.IRepositories
{
    public interface IStudentRepository : IRepository<Student>
    {
        IEnumerable<Student> GetAssignmentsPerStudent();
        IEnumerable<Student> GetAStudentWithMultiCourses();
    }
}
