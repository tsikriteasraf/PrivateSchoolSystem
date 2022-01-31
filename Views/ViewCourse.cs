using PrivateScoolSystem.Entities;
using PrivateScoolSystem.Enums;
using System;
using System.Collections.Generic;
using PrivateScoolSystem.Views.Validations;

namespace PrivateScoolSystem.Views
{
   internal class ViewCourse :Validation
    {
        public static void PrintAll(IEnumerable<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"Id----Title-------Stream------Type---------Start Date---------End Date");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.WriteLine($@"{course.Id,-6}{course.Title,-5}{' ',8}{course.Stream}{' ',5} {course.Type,-10}{' ',5} {course.Start_Date.ToShortDateString(),-10}{' ',7} {course.End_Date.ToShortDateString(),-10}");
            }
        }
        public static Course CreateInputCourse()
        {
            //Title
            Console.WriteLine(@"Give the Course's title");
            var title = Console.ReadLine();

            //Stream
            var choice = 1;
            CourseStreamEnum stream = 0;
            do
            {
                try
                {
                    Console.WriteLine(@"Choose the Course's stream");
                    Console.WriteLine(@"1-CB8  2-CB9  3-CB10  4-CB11  5-CB12");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1: stream = (CourseStreamEnum)choice; break;
                        case 2: stream = (CourseStreamEnum)choice; break;
                        case 3: stream = (CourseStreamEnum)choice; break;
                        case 4: stream = (CourseStreamEnum)choice; break;
                        case 5: stream = (CourseStreamEnum)choice; break;
                        default: Console.WriteLine(@"Not a valid choice. Please try again"); break;

                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            } while (choice != 1 && choice != 2 && choice != 3 && choice != 4 && choice != 5);

            //TYPE
            CourseTypeEnum type = 0;
            do
            {
                try
                {
                    Console.WriteLine(@"Choose the course's type");
                    Console.WriteLine(@"1-FullTime  2-PartTime");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: type = (CourseTypeEnum)choice; break;
                        case 2: type = (CourseTypeEnum)choice; break;
                        default: Console.WriteLine(@"Not a valid choice. Please try again"); break;
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            } while (choice != 1 && choice != 2);

            //Start_Date
            var startDate = IsValidDate("course", "starting date");
            //End_Date
            var endDate = IsValidDateCourse("course", "end date", startDate, choice);
            var course = new Course
            {
                Title = title,
                Stream = stream,
                Type = type,
                Start_Date = startDate,
                End_Date = endDate
            };
            return course;
        }
    }
}
