using PrivateScoolSystem.Entities;
using System.Collections.Generic;

namespace PrivateScoolSystem.IRepositories
{
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> GetTrainersPerCourse();
        IEnumerable<Course> GetStudentsPerCourse();
    }
}
