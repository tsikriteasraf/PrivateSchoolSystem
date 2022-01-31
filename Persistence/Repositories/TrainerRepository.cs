using PrivateScoolSystem.Entities;
using PrivateScoolSystem.IRepositories;
using PrivateScoolSystem.Persistence.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
namespace PrivateScoolSystem.Repositories
{
    public class TrainerRepository : Repository<Trainer>, ITrainerRepository
    {
        public TrainerRepository(PrivateSchoolDbContext context)
         : base(context)
        {
        }
        public PrivateSchoolDbContext PrivateSchoolDbContext=> Context as PrivateSchoolDbContext;
        public IEnumerable<Course> GetTrainersPerCourse()
        {
           return PrivateSchoolDbContext.Courses.Include(x=>x.Trainers).OrderBy(x=>x.Title).ToList();
        }
    }
}
