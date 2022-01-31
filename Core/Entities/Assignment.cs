using System;

namespace PrivateScoolSystem.Entities
{
  public class Assignment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public int OralMark { get; set; }
        public int TotalMark { get; set; }
        public Course Course { get; set; }
    }
}
