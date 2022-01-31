using PrivateScoolSystem.Entities;
using System;
using System.Collections.Generic;
using PrivateScoolSystem.Views.Validations;

namespace PrivateScoolSystem.Views
{
   internal class ViewTrainer:Validation
    {
        public static void PrintAll(IEnumerable<Trainer>trainers)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"Id---First Name----Last Name---------Subject");
            Console.ResetColor();
            foreach (var trainer in trainers)
            {
                Console.WriteLine($@"{trainer.Id,-5}{trainer.First_Name,-15}{trainer.Last_Name,-15}{trainer.Subject,-10}");
            }
        }
        public static void PrintTrainersPerCourse(IEnumerable<Course> courses)
        {

            foreach (var course in courses)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($@"Course: {course.Title}  {course.Type}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(@"Fist Name-----Last Name");
                Console.ResetColor();
                foreach (var trainer in course.Trainers)
                {
                    Console.WriteLine($@"{trainer.First_Name,-15}{trainer.Last_Name,-15}");
                }
            }
        }
        public static Trainer CreateInputTrainer()
        {
            var firstName = IsValidName("first", "trainer");
            var lastName = IsValidName("last", "trainer");
            var subject = IsValidCourse("trainer");
            var trainer = new Trainer
            {
                First_Name = firstName,
                Last_Name = lastName,
                Subject = subject
            };
            return trainer;
        }
    }
}
