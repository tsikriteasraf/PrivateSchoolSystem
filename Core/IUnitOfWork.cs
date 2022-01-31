using PrivateScoolSystem.IRepositories;
using System;


namespace PrivateScoolSystem.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
        ITrainerRepository Trainers { get; }
        IAssignmentRepository Assignments { get; }
        IStudentRepository Students { get; }
        int Complete();
    }
}
