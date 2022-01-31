using System;
using System.Collections.Generic;

namespace PrivateScoolSystem.Entities
{
  public  class Student
    {
        //In case we want EagerLoading
        public Student()
        {
            Courses = new HashSet<Course>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int TuitionFees { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
