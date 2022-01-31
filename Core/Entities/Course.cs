using PrivateScoolSystem.Enums;
using System;
using System.Collections.Generic;

namespace PrivateScoolSystem.Entities
{
   public  class Course
    {
        //In case we want EagerLoading
        public Course()
        {
            Trainers = new HashSet<Trainer>();
            Students = new HashSet<Student>();
            Assignments = new HashSet<Assignment>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public CourseStreamEnum Stream { get; set; }

        public CourseTypeEnum Type { get; set; }

        public DateTime Start_Date { get; set; }

        public DateTime End_Date { get; set; }

        public virtual ICollection<Trainer> Trainers { get; set; } 
        public virtual ICollection<Student> Students { get; set; } 
        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}
