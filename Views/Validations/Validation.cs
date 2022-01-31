using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using PrivateScoolSystem.Entities;
using PrivateScoolSystem.Views.Helpers;

namespace PrivateScoolSystem.Views.Validations
{
   internal class Validation
    {
        //Queryables
      static Predicate<string> stringQueryable = s => Regex.IsMatch(s, @"[^a-zA-Z]|^$");
      static Predicate<string> stringQueryable2 = s => Regex.IsMatch(s, @"[^a-zA-Z#+]");
      static Predicate<string> stringQueryable3 = s => Regex.IsMatch(s, @"[^a-zA-Z0-9]");

        //Methods
        public static string IsValidName(string nameType, string personType)
        {
            var isValid = true;
            string firstName;
            do
            {
                Helper.PrintValidNames(personType, nameType);
                firstName = Console.ReadLine();
                isValid = stringQueryable(firstName);
            } while (isValid);
            return firstName;
        }

        public static int IsValidNumber()
        {
            var tuitionFees = 0;
            var validFormat = true;
            var inRangeFees = true;
            do
            {
                try
                {
                    Helper.PrintValidNumber();
                    tuitionFees = Convert.ToInt32(Console.ReadLine());
                    inRangeFees = tuitionFees < 1000 || tuitionFees > 10000;
                    validFormat = false;
                }
                catch (FormatException e)
                {

                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (validFormat || inRangeFees);
            return tuitionFees;
        }
  
        public static int IsValidScore()
        {
           var score = 0;
           var  validFormat = true;
           var  inRangeScore = true;
            do
            {
                try
                {
                    Helper.PrintValidScore();
                    score = Convert.ToInt32(Console.ReadLine());
                    inRangeScore = score < 0 || score > 100;
                    validFormat = false;

                }
                catch (FormatException e)
                {

                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (validFormat || inRangeScore);
            return score;
        }
        public static int IsValidLinkingStudent(IEnumerable<Student> students)
        {
           var score = 0;
           var  validFormat = true;
           var  inRangescore = true;
            do
            {
                try
                {
                    Helper.PrintValidIdStudent();
                    score = Convert.ToInt32(Console.ReadLine());
                    inRangescore = !students.Any(x => x.Id == score);
                    validFormat = false;
                }
                catch (FormatException e)
                {

                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (validFormat || inRangescore);
            return score;
        }
        public static int IsValidLinkingTrainer(IEnumerable<Trainer> trainers)
        {
            var score = 0;
            var  validFormat = true;
            var  inRangescore = true;
            do
            {
                try
                {
                    Helper.PrintValidIdTrainer();
                    score = Convert.ToInt32(Console.ReadLine());
                    inRangescore = trainers.Any(x => x.Id == score) ? false : true;
                    validFormat = false;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (validFormat || inRangescore);
            return score;
        }
        public static int IsValidLinkingAssignment(IEnumerable<Assignment> assignments)
        {
           var score = 0;
           var  validFormat = true;
           var  inRangescore = true;
            do
            {
                try
                {
                    Helper.PrintValidAssignmentId();
                    score = Convert.ToInt32(Console.ReadLine());
                    inRangescore = assignments.Any(x => x.Id == score) ? false : true;
                    validFormat = false;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (validFormat || inRangescore);
            return score;
        }
        public static int IsValidLinkingCourse(IEnumerable<Course> courses)
        {
           var score = 0;
           var  validFormat = true;
           var  inRangescore = true;
            do
            {
                try
                {
                    Helper.PrintValidCourseId();
                    score = Convert.ToInt32(Console.ReadLine());
                    inRangescore = courses.Any(x => x.Id == score) ? false : true;
                    validFormat = false;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (validFormat || inRangescore);
            return score;
        }
        public static DateTime IsValidDate(string personType, string dateType)
        {
            var date = DateTime.Now;
            var isValidDate = true;
            do
            {
                try
                {
                    Helper.PrintValidDate(personType, dateType);
                    date = DateTime.Parse(Console.ReadLine());
                    isValidDate = date > DateTime.Now;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!isValidDate);
            return date;
        }
        public static DateTime IsValidBirthday(string personType, string dateType)
        {
            var birthday = DateTime.Now;
            var isValidDate = true;
            do
            {
                try
                {
                    Helper.PrintValidBirthDay(personType, dateType);
                    birthday = DateTime.Parse(Console.ReadLine());
                    isValidDate = birthday < DateTime.Now.AddYears(-7);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!isValidDate);
            return birthday;
        }
        public static DateTime IsValidDateCourse(string personType, string dateType, DateTime startingDate, int choice)
        {
            var date = DateTime.Now;
            var isValidDate = true;
            do
            {
                try
                {
                    Helper.PrintValidDateCourse(personType, dateType);
                    date = DateTime.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        isValidDate = date < startingDate.AddMonths(6);
                    }
                    else if (choice == 2)
                    {
                        isValidDate = date < startingDate.AddMonths(3);
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (isValidDate);
            return date;
        }
        public static IEnumerable<Assignment> IsValidSpecifiedDate(IEnumerable<Assignment> assignments)
        {
            var assignments1 = new List<Assignment>();
            var isValidDate = true;
            var inputDate = DateTime.Now;
            var start = DateTime.Parse("2019-1-1");
            var end = DateTime.Parse("2050-6-30");
            var from = DateTime.Now;
            var to = DateTime.Now;
            do
            {
                try
                {
                    Helper.PrintSpecifiedDate(start,end);
                    inputDate = DateTime.Parse(Console.ReadLine());
                    isValidDate = !(inputDate >= start && inputDate <= end);
                    if (isValidDate != false) continue;
                    switch (inputDate.DayOfWeek)
                    {
                        case DayOfWeek.Sunday:
                            @from = inputDate.AddDays(-6); to = inputDate.AddDays(-2);
                            break;
                        case DayOfWeek.Monday:
                            @from = inputDate; to = inputDate.AddDays(4);
                            break;
                        case DayOfWeek.Tuesday:
                            @from = inputDate.AddDays(-1); to = inputDate.AddDays(3);
                            break;
                        case DayOfWeek.Wednesday:
                            @from = inputDate.AddDays(-2); to = inputDate.AddDays(2);
                            break;
                        case DayOfWeek.Thursday:
                            @from = inputDate.AddDays(-3); to = inputDate.AddDays(1);
                            break;
                        case DayOfWeek.Friday:
                            @from = inputDate.AddDays(-4); to = inputDate;
                            break;
                        case DayOfWeek.Saturday:
                            @from = inputDate.AddDays(-5); to = inputDate.AddDays(-1);
                            break;
                        default:
                            break;
                    }

                    assignments1.AddRange(assignments.Where(assignment => assignment.SubDateTime >= @from && assignment.SubDateTime <= to));
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (isValidDate);
            return assignments1;
        }
        public static string IsValidCourse(string personType)
        {
            var isValid = true;
            var subject = " ";
            do
            {
                try
                {
                    Helper.PrintCourseTitle(personType);
                    subject = Console.ReadLine();
                    isValid = stringQueryable2(subject);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (isValid);
            return subject;
        }
        public static string IsValidCourse1()
        {
            var isValid = true;
            var subject = " ";
            do
            {
                try
                {
                    Helper.PrintCourseTitle();
                    subject = Console.ReadLine();
                    isValid = stringQueryable2(subject);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (isValid);
            return subject;
        }
        public static string IsValidAssignmentTitle()
        {
            var isValid = true;
            var title = " ";
            do
            {
                try
                {
                    Helper.PrintAssignmentTitle();
                    title = Console.ReadLine();
                    isValid = stringQueryable3(title);
                }
                catch (FormatException e)
                {

                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (isValid);
            return title;
        }
    }
}
