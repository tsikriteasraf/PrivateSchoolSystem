using System;

namespace PrivateScoolSystem.Views.Helpers
{
    public class Helper
    {
        public static void PrintValidNames(string personType, string nameType) => Console.WriteLine($@"Give the {personType}'s {nameType} name (No symbols or numbers allowed)");
        public static void PrintValidNumber() => Console.WriteLine(@"Give the student's tuition fees  (must be >=1000 & <=10000)");
        public static void PrintValidScore() => Console.WriteLine(@"Give the assignment's score. (must be >=0 & <=100)");
        public static void PrintValidIdStudent() => Console.WriteLine(@"Give the student's id.");
        public static void PrintValidIdTrainer() => Console.WriteLine(@"Give the trainer's id.");
        public static void PrintValidAssignmentId() => Console.WriteLine(@"Give the assignment's id.");
        public static void PrintValidCourseId() => Console.WriteLine(@"Give the course's id.");
        public static void PrintValidDate(string personType, string dateType) => Console.WriteLine($@"Give the {personType}'s {dateType}   ex.(yyyy-mm-dd).The date cannot be in the past.");
        public static void PrintValidBirthDay(string personType, string dateType) => Console.WriteLine($@"Give the {personType}'s {dateType}   ex.(yyyy-mm-dd).The person must be at least 7 years old.");
        public static void PrintValidDateCourse(string personType, string dateType) => Console.WriteLine($@"Give the {personType}'s {dateType}   ex.(yyyy-mm-dd)");
        public static void PrintSpecifiedDate(DateTime start, DateTime end)
        {
            Console.WriteLine($@"Give the date that you would like to check for " +
            $@"ex.(yyyy-mm-dd valid dates are between {start.ToShortDateString()} & {end.ToShortDateString()})");
        }
        public static void PrintCourseTitle(string personType) => Console.WriteLine($@"Give the {personType}'s subject");
        public static void PrintCourseTitle() => Console.WriteLine($@"Give the Course's Title");
        public static void PrintAssignmentTitle() => Console.WriteLine($@"Give the assignment's title  (only letters and numbers allowed)");

    
    }
}
