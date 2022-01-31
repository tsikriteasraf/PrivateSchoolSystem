using PrivateScoolSystem.Entities;
using System;
using System.Collections.Generic;
using PrivateScoolSystem.Views.Validations;

namespace PrivateScoolSystem.Views
{
    internal class ViewStudent :Validation
    {
        public static void PrintAll(IEnumerable<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"Id---First Name------Last Name-------Date of Birth------Tuition Fees");
            Console.ResetColor();
            foreach (var stu in students)
            {
                Console.WriteLine($@"{stu.Id,-5}{stu.FirstName,-15} {stu.LastName,-15} {stu.DateOfBirth.ToShortDateString(),-15} {' ',5}{stu.TuitionFees,-15}");
            }
        }
        public static void PrintStudentsPerCourse(IEnumerable<Course> courses)
        {
            foreach (var course in courses)
            {
           
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($@"Course: {course.Title}  {course.Type}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(@"Fist Name-----Last Name");
                Console.ResetColor();
                foreach (var student in course.Students)
                {
                    Console.WriteLine($@"{student.FirstName,-15}{student.LastName,-15}");
                }
            }
        }
        public static void PrintStudentMoreCourses(IEnumerable<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"First Name-------Last Name------Courses");
            Console.ResetColor();
            foreach (var stu in students)
            {
                    Console.WriteLine($@"{stu.FirstName,-15} {stu.LastName,-15}-------");
                    foreach (var course in stu.Courses)
                    {
                        Console.WriteLine($@"{course.Title,37}{' ',3}");
                    }
            }
        }
        public static Student CreateInputStudent()
        {
            var firstName = IsValidName("first", "student");
            var lastName = IsValidName("last", "student");
            var birthday = IsValidBirthday("student", "Date Of Birth");
            var tuitionFees = IsValidNumber();
            var student = new Student
            {
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = birthday,
                TuitionFees = tuitionFees
            };
            return student;
        }
    }
}
