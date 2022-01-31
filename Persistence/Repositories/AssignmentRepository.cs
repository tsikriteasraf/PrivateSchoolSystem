using PrivateScoolSystem.Entities;
using PrivateScoolSystem.IRepositories;
using PrivateScoolSystem.Persistence.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
namespace PrivateScoolSystem.Repositories
{
   public class AssignmentRepository:Repository<Assignment> ,IAssignmentRepository
    {
        public AssignmentRepository(PrivateSchoolDbContext context)
         : base(context)
        {
        }
        public PrivateSchoolDbContext PrivateSchoolDbContext=>Context as PrivateSchoolDbContext; 
        public IEnumerable<Course> GetAssignmentsPerCourse()
        {
            return PrivateSchoolDbContext.Courses
                .Include(x=>x.Assignments)
                .OrderBy(x => x.Title)
                .ToList();
        }
    }
}
