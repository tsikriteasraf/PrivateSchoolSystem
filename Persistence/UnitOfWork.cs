using PrivateScoolSystem.Core;
using PrivateScoolSystem.IRepositories;
using PrivateScoolSystem.Repositories;

namespace PrivateScoolSystem.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PrivateSchoolDbContext _context;

        public UnitOfWork(PrivateSchoolDbContext context)
        {
            _context = context;
            Courses = new CourseRepository(_context);
            Trainers = new TrainerRepository(_context);
            Students = new StudentRepository(_context);
            Assignments = new AssignmentRepository(_context);
        }

        public ICourseRepository Courses { get; private set; }
        public IStudentRepository Students { get; private set; }
        public ITrainerRepository Trainers { get; private set; }
        public IAssignmentRepository Assignments { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
