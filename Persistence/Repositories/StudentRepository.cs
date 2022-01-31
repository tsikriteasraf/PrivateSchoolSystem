using PrivateScoolSystem.Entities;
using PrivateScoolSystem.IRepositories;
using PrivateScoolSystem.Persistence.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace PrivateScoolSystem.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(PrivateSchoolDbContext context)
         : base(context)
        {
        }
        public PrivateSchoolDbContext PrivateSchoolDbContext=> Context as PrivateSchoolDbContext;
        public IEnumerable<Student> GetAssignmentsPerStudent()
        {
            return PrivateSchoolDbContext.Students
                .Include(x=>x.Courses)
                .OrderBy(x => x.FirstName)
                .ToList();
        }
        public IEnumerable<Student> GetAStudentWithMultiCourses()
        {
            return PrivateSchoolDbContext.Students
                .Include(x=>x.Courses)
                .Where(x=>x.Courses.Count()>1)
                .OrderBy(x => x.FirstName)
                .ToList();
        }
    }
}
