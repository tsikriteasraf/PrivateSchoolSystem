using PrivateScoolSystem.Entities;
using System.Data.Entity;

namespace PrivateScoolSystem
{
   public class PrivateSchoolDbContext:DbContext
    {
        public PrivateSchoolDbContext():base("name=PrivateSchoolDbContext")
        {
            Database.SetInitializer<PrivateSchoolDbContext>(new CreateDatabaseIfNotExists<PrivateSchoolDbContext>());
            //In Case we want Eager Loading
            //this.Configuration.LazyLoadingEnabled = false;
        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Assignment> Assignments { get; set; }
    }
}
