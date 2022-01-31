using PrivateScoolSystem.Entities;
using System;
using System.Collections.Generic;
using PrivateScoolSystem.Views.Validations;

namespace PrivateScoolSystem.Views
{
    internal class ViewAssignment :Validation
    {

        public static void PrintAllStudentsWithAssignmentAtDate(IEnumerable<Assignment> assignments, IEnumerable<Course> courses)
        {
            foreach (var assignment in assignments)
            {
                if (assignment.Course == null) Console.WriteLine($@" Assignment with id {assignment.Id} is not assigned yet.Please try again.");
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($@"{assignment.Title} of {assignment.Course.Title} {assignment.Course.Type} has to be submitted by the following students this week: ");
                    Console.ResetColor();
                    foreach (var stu in assignment.Course.Students)
                    {
                        Console.WriteLine($@"{stu.FirstName,5} {stu.LastName}");
                    }
                }
            }
        }
        public static void PrintAll(IEnumerable<Assignment> assignments)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"Id---Title-----------------------Description----------------------------------------------SubDate Time------------------Oral Mark-----Total Mark");
            Console.ResetColor();
            foreach (var assignment in assignments)
            {
                Console.WriteLine($@"{assignment.Id,-5}{assignment.Title,-15}{' ',3}{assignment.Description,-40}{' ',30} {assignment.SubDateTime.ToShortDateString(),-30} {assignment.OralMark,-10} {assignment.TotalMark,-10}");
            }
        }
        public static void PrintAssignmentsPerCourse(IEnumerable<Course> courses)
        {

            foreach (var course in courses)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($@"Course: {course.Title}  {course.Type}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(@"Title------------------------Description");
                Console.ResetColor();
                foreach (var assignment in course.Assignments)
                {
                    Console.WriteLine($@"{assignment.Title,-15}{' ',5}{assignment.Description,-15}");
                }
            }
        }
        public static void PrintAssignmentsPerStudent(IEnumerable<Student> students)
        {
            foreach (var stu in students)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($@"{stu.FirstName,-15}{' ',5}{stu.LastName,-15}");
                Console.ResetColor();
                foreach (var course in stu.Courses)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($@"{course.Title} {course.Type}");
                    Console.ResetColor();
                    Console.WriteLine($@"Title--------------------Description");
                    foreach (var assignment in course.Assignments)
                    {
                        Console.WriteLine($@"{assignment.Title}{' ',5}{assignment.Description,-15}");
                    }
                }
            }
        }
        public static Assignment CreateInputAssignment()
        {
            var title = IsValidAssignmentTitle();
            Console.WriteLine(@"Give the Assignment's Description");
            var description = Console.ReadLine();
            var subDateTime = IsValidDate("assignment", "sub date time");
            var oralMark = IsValidScore();
            var totalMark = IsValidScore();
            var assignment = new Assignment
            {
                Title = title,
                Description = description,
                SubDateTime = subDateTime,
                OralMark = oralMark,
                TotalMark = totalMark
            };
            return assignment;
        }
    }
}
