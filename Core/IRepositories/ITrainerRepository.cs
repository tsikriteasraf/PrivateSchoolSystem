using PrivateScoolSystem.Entities;
using System.Collections.Generic;

namespace PrivateScoolSystem.IRepositories
{
    public interface ITrainerRepository : IRepository<Trainer>
    {
        IEnumerable<Course> GetTrainersPerCourse();
    }

}
