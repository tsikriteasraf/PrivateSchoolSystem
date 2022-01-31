using System.Collections.Generic;

namespace PrivateScoolSystem.Entities
{
   public  class Trainer
    {
        //In case we want EagerLoading
        public Trainer()
        {
            Courses = new HashSet<Course>();
        }

        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Subject { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
