using PrivateScoolSystem.Entities;
using PrivateScoolSystem.IRepositories;
using PrivateScoolSystem.Persistence.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
namespace PrivateScoolSystem.Repositories
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(PrivateSchoolDbContext context)
            : base(context)
        {
        }
        public PrivateSchoolDbContext PrivateSchoolDbContext=> Context as PrivateSchoolDbContext; 
      
        public IEnumerable<Course> GetStudentsPerCourse()
        {
            return PrivateSchoolDbContext.Courses
                .Include(x=>x.Students)
                .OrderBy(x => x.Title)
                .ToList();
        }
        public IEnumerable<Course> GetTrainersPerCourse()
        {
            return PrivateSchoolDbContext.Courses
                .Include(x=>x.Trainers)
                .OrderBy(x => x.Title)
                .ToList();
        }
    }
}
