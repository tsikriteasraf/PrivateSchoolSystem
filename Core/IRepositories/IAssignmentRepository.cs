using PrivateScoolSystem.Entities;
using System.Collections.Generic;

namespace PrivateScoolSystem.IRepositories
{
    public interface IAssignmentRepository:IRepository<Assignment>
    {
        IEnumerable<Course> GetAssignmentsPerCourse();
   
    }
}
