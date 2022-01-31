using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using PrivateScoolSystem.Entities;
using PrivateScoolSystem.Enums;
using PrivateScoolSystem.Views.Helpers;

namespace PrivateSchoolSystem.Migrations
{
    using PrivateScoolSystem;
    using System.Data.Entity.Migrations;


    internal sealed class Configuration : DbMigrationsConfiguration<PrivateSchoolDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PrivateSchoolDbContext context)
        {

            //Student s1 = new Student(){FirstName = "Rafael",LastName = "Tsikriteas",DateOfBirth = new DateTime(1993, 5, 17),TuitionFees = 2500};
            //Student s2 = new Student(){FirstName = "Jadyn",LastName = "Schroeder",DateOfBirth = new DateTime(2000, 3, 11),TuitionFees = 2500};
            //Student s3 = new Student(){FirstName = "Eleanor",LastName = "Barnett",DateOfBirth = new DateTime(1995, 6, 22),TuitionFees = 2500};
            //Student s4 = new Student(){FirstName = "Isabelle",LastName = "Stafford",DateOfBirth = new DateTime(1996, 2, 13),TuitionFees = 2500};
            //Student s5 = new Student{FirstName = "Keith",LastName = "Maynard",DateOfBirth = new DateTime(1997, 5, 19),TuitionFees = 2500};
            //Student s6 = new Student(){FirstName = "Violet",LastName = "Leblanc",DateOfBirth = new DateTime(1978, 4, 30),TuitionFees = 2500};
            //Student s7 = new Student(){FirstName = "Demarion",LastName = "Rios",DateOfBirth = new DateTime(1989, 10, 10),TuitionFees = 2500};
            //Student s8 = new Student(){FirstName = "Felicity",LastName = "Rosales",DateOfBirth = new DateTime(1992, 5, 10),TuitionFees = 2500};
            //Student s9 = new Student(){FirstName = "Perla",LastName = "Dennis",DateOfBirth = new DateTime(1990, 6, 15),TuitionFees = 2500};
            //Student s10 = new Student(){FirstName = "Isai",LastName = "Barnett",DateOfBirth = new DateTime(1991, 3, 12),TuitionFees = 2500};
            //Student s11 = new Student(){FirstName = "Evie",LastName = "Solomon",DateOfBirth = new DateTime(1998, 1, 21),TuitionFees = 2500};
            //Student s12 = new Student(){FirstName = "Alberto",LastName = "Irwin",DateOfBirth = new DateTime(1988, 5, 1),TuitionFees = 2500};
            //Student s13 = new Student(){ FirstName = "Kaden",LastName = "Simmons",DateOfBirth = new DateTime(2001, 2, 12),TuitionFees = 2500};
            //Student s14 = new Student(){FirstName = "Arjun",LastName = "Powers",DateOfBirth = new DateTime(1990, 1, 19),TuitionFees = 2500};
            //Student s15 = new Student(){ FirstName = "Antonio",LastName = "Mclean",DateOfBirth = new DateTime(1987, 5, 17),TuitionFees = 2500};
            //Student s16 = new Student(){FirstName = "Nikhil",LastName = "Miles",DateOfBirth = new DateTime(1999, 2, 25),TuitionFees = 2500};
            //Student s17 = new Student(){FirstName = "Aylin",LastName = "Craig",DateOfBirth = new DateTime(2000, 2, 1),TuitionFees = 2500};
            //Student s18 = new Student(){FirstName = "Mohamed",LastName = "Herring",DateOfBirth = new DateTime(1970, 1, 18),TuitionFees = 2500};
            //Student s19 = new Student(){FirstName = "Aden",LastName = "Richards",DateOfBirth = new DateTime(1998, 3, 5),TuitionFees = 2500};
            //Student s20 = new Student(){FirstName = "Haven",LastName = "Mckay",DateOfBirth = new DateTime(1995, 2, 19),TuitionFees = 2500};
          
      
            //Course c1 = new Course(){Title = "C#",Stream = CourseStreamEnum.CB8,Type = CourseTypeEnum.FullTime,Start_Date = new DateTime(2019, 1, 1),End_Date = new DateTime(2019, 6, 30)};
            //Course c2 = new Course(){Title = "C#",Stream = CourseStreamEnum.CB8,Type = CourseTypeEnum.PartTime,Start_Date = new DateTime(2019, 1, 1),End_Date = new DateTime(2019, 3, 31)};
            //Course c3 = new Course(){Title = "Java",Stream = CourseStreamEnum.CB8,Type = CourseTypeEnum.FullTime,Start_Date = new DateTime(2019, 1, 1),End_Date = new DateTime(2019, 6, 30)};
            //Course c4 = new Course(){Title = "Java",Stream = CourseStreamEnum.CB8,Type = CourseTypeEnum.PartTime,Start_Date = new DateTime(2019, 1, 1),End_Date = new DateTime(2019, 3, 31)};

            //Trainer t1 = new Trainer(){First_Name = "Bethany",Last_Name = "Scott",Subject = "C#"};
            //Trainer t2 = new Trainer(){First_Name = "Philip",Last_Name = "Gibbs",Subject = "C#"};
            //Trainer t3 = new Trainer(){First_Name = "Morgan",Last_Name = "Simpson", Subject = "C#"};
            //Trainer t4 = new Trainer() {First_Name = "Clare", Last_Name = "Hill", Subject = "C#"};
            //Trainer t5 = new Trainer(){First_Name = "Jacey",Last_Name = "Campos",Subject = "Java"};
            //Trainer t6 = new Trainer(){First_Name = "Jordon",Last_Name = "Lawson",Subject = "Java"};
            //Trainer t7 = new Trainer(){First_Name = "Jerome",Last_Name = "Mccann",Subject = "Java"};
            //Trainer t8 = new Trainer(){First_Name = "Andreas", Last_Name = "Blackwell",Subject = "Java"};

            //Assignment a1 = new Assignment(){Title = "Assignment 1",Description = "Design of a private school structure",SubDateTime = new DateTime(2019, 1, 16),OralMark = 70,TotalMark = 80};
            //Assignment a2 = new Assignment(){Title = "Assignment 2",Description = "Design of a public school structure",SubDateTime = new DateTime(2019, 2, 1),OralMark = 75,TotalMark = 85};
            //Assignment a3 = new Assignment(){Title = "Assignment 3",Description = "Design of a streaming service",SubDateTime = new DateTime(2019, 2, 16),OralMark = 72,TotalMark = 80};
            //Assignment a4 = new Assignment(){ Title = "Assignment 4",Description = "Design of a website",SubDateTime = new DateTime(2019, 2, 28),OralMark = 56,TotalMark = 89};
            //Assignment a5 = new Assignment(){Title = "Assignment 5",Description = "Design of a dating app",SubDateTime = new DateTime(2019, 3, 1),OralMark = 90,TotalMark = 95};
            //Assignment a6 = new Assignment(){Title = "Project 1",Description = "Design of a game platform",SubDateTime = new DateTime(2019, 3, 1),OralMark = 76,TotalMark = 81};
            //Assignment a7 = new Assignment(){Title = "Project 2",Description = "Design of a social media app",SubDateTime = new DateTime(2019, 3, 31),OralMark = 81,TotalMark = 89};
            //Assignment a8 = new Assignment(){Title = "Assignment 1",Description = "Design of a coding bootcamp structure",SubDateTime = new DateTime(2019, 1, 16),OralMark = 73,TotalMark = 82};
            //Assignment a9 = new Assignment(){Title = "Assignment 2",Description = "Design of a diving structure",SubDateTime = new DateTime(2019, 2, 15),OralMark = 71,TotalMark = 76};
            //Assignment a10 = new Assignment(){Title = "Assignment 3",Description = "Design of a game streaming service",SubDateTime = new DateTime(2019, 2, 16),OralMark = 77,TotalMark = 81};
            //Assignment a11 = new Assignment(){Title = "Assignment 4",Description = "Design of a photo sharing app",SubDateTime = new DateTime(2019, 3, 1),OralMark = 56,TotalMark = 62};
            //Assignment a12 = new Assignment(){Title = "Assignment 5",Description = "Design of an online office suite",SubDateTime = new DateTime(2019, 3, 30),OralMark = 66,TotalMark = 68};
            //Assignment a13 = new Assignment(){Title = "Project 1",Description = "Design of a video streaming service",SubDateTime = new DateTime(2019, 4, 28),OralMark = 72,TotalMark = 80};
            //Assignment a14 = new Assignment(){Title = "Project 2",Description = "Design of a bibliographic database",SubDateTime = new DateTime(2019, 6, 30),OralMark = 81,TotalMark = 89};
            //Assignment a15 = new Assignment(){Title = "Assignment 1",Description = "Design of a web calendar",SubDateTime = new DateTime(2019, 1, 16),OralMark = 55,TotalMark = 60};
            //Assignment a16 = new Assignment(){Title = "Assignment 2",Description = "Design of an online file editing",SubDateTime = new DateTime(2019, 2, 1),OralMark = 66,TotalMark = 89};
            //Assignment a17 = new Assignment(){Title = "Assignment 3",Description = "Design of a mapping app",SubDateTime = new DateTime(2019, 2, 16),OralMark = 87,TotalMark = 94};
            //Assignment a18 = new Assignment(){Title = "Assignment 4",Description = "Design of a blog",SubDateTime = new DateTime(2019, 2, 28),OralMark = 53,TotalMark = 65};
            //Assignment a19 = new Assignment(){Title = "Assignment 5",Description = "Design of a parking app",SubDateTime = new DateTime(2019, 3, 1),OralMark = 83,TotalMark = 88};
            //Assignment a20 = new Assignment(){Title = "Project 1",Description = "Design of a publication management app",SubDateTime = new DateTime(2019, 3, 1),OralMark = 72,TotalMark = 80};
            //Assignment a21 = new Assignment(){Title = "Project 2",Description = "Design of a web mail service",SubDateTime = new DateTime(2019, 3, 31),OralMark = 81,TotalMark = 93};
            //Assignment a22 = new Assignment(){Title = "Assignment 1",Description = "Design of a forum",SubDateTime = new DateTime(2019, 1, 16),OralMark = 72,TotalMark = 84};
            //Assignment a23 = new Assignment(){Title = "Assignment 2",Description = "Design of a mailing lists app",SubDateTime = new DateTime(2019, 2, 15),OralMark = 73,TotalMark = 79};
            //Assignment a24 = new Assignment(){Title = "Assignment 3",Description = "Design of an RSS reader",SubDateTime = new DateTime(2019, 2, 16),OralMark = 78,TotalMark = 98};
            //Assignment a25 = new Assignment(){Title = "Assignment 4",Description = "Design of a web chat",SubDateTime = new DateTime(2019, 3, 1),OralMark = 56,TotalMark = 65};
            //Assignment a26 = new Assignment(){Title = "Assignment 5",Description = "Design of a virtual world app",SubDateTime = new DateTime(2019, 3, 30),OralMark = 68,TotalMark = 79};
            //Assignment a27 = new Assignment(){Title = "Project 1",Description = "Design of a password manager",SubDateTime = new DateTime(2019, 4, 30),OralMark = 76,TotalMark = 87};
            //Assignment a28 = new Assignment(){Title = "Project 2",Description = "Design of a translation app",SubDateTime = new DateTime(2019, 6, 30),OralMark = 90,TotalMark = 99};
            ////#region PairingStudents

            ////Helper.Pair(s1, c1);
            ////Helper.Pair(s2, c1);
            ////Helper.Pair(s3, c1);
            ////Helper.Pair(s4, c1);
            ////Helper.Pair(s5, c1);
            ////Helper.Pair(s6, c1);
            ////Helper.Pair(s7, c1);
            ////Helper.Pair(s8, c1);
            ////Helper.Pair(s9, c1);
            ////Helper.Pair(s10, c1);
            ////Helper.Pair(s11, c1);
            ////Helper.Pair(s12, c1);
            ////Helper.Pair(s13, c1);
            ////Helper.Pair(s14, c1);
            ////Helper.Pair(s15, c1);
            ////Helper.Pair(s16, c1);
            ////Helper.Pair(s17, c1);
            ////Helper.Pair(s18, c1);
            ////Helper.Pair(s19, c1);
            ////Helper.Pair(s20, c1);

            ////#endregion


            ////#region PairingTrainers

            ////Helper.Pair(t1, c1);
            ////Helper.Pair(t2, c1);
            ////Helper.Pair(t3, c2);
            ////Helper.Pair(t4, c2);
            ////Helper.Pair(t5, c3);
            ////Helper.Pair(t6, c3);
            ////Helper.Pair(t7, c4);
            ////Helper.Pair(t8, c4);

            ////#endregion

            ////#region PairingAssignments
            ////Helper.Pair(a1, c1);
            ////Helper.Pair(a2, c1);
            ////Helper.Pair(a3, c1);
            ////Helper.Pair(a4, c1);
            ////Helper.Pair(a5, c1);
            ////Helper.Pair(a6, c1);
            ////Helper.Pair(a7, c1);
            ////Helper.Pair(a8, c2);
            ////Helper.Pair(a9, c2);
            ////Helper.Pair(a10, c2);
            ////Helper.Pair(a11, c2);
            ////Helper.Pair(a12, c2);
            ////Helper.Pair(a13, c2);
            ////Helper.Pair(a14, c2);
            ////Helper.Pair(a15, c3);
            ////Helper.Pair(a16, c3);
            ////Helper.Pair(a17, c3);
            ////Helper.Pair(a18, c3);
            ////Helper.Pair(a19, c3);
            ////Helper.Pair(a20, c3);
            ////Helper.Pair(a21, c3);
            ////Helper.Pair(a22, c4);
            ////Helper.Pair(a23, c4);
            ////Helper.Pair(a24, c4);
            ////Helper.Pair(a25, c4);
            ////Helper.Pair(a26, c4);
            ////Helper.Pair(a27, c4);
            ////Helper.Pair(a28, c4);



            ////#endregion

            //List<Course> courses = new List<Course>() { c1, c2, c3, c4 };
            //List<Student> students = new List<Student>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s17, s17, s18, s19, s20};
            //List<Trainer> trainers = new List<Trainer>() { t1, t2, t3, t4, t5, t6, t7, t8 };
            //List<Assignment> ass = new List<Assignment>() { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28 }; 
            //students.ForEach(x=>context.Students.AddOrUpdate(s=>new{s.FirstName,s.LastName,s.DateOfBirth,s.TuitionFees},x));
            //courses.ForEach(c=>context.Courses.AddOrUpdate(x=>new{x.Title,x.Stream,x.Type,x.Start_Date,x.End_Date},c));
            //ass.ForEach(a=>context.Assignments.AddOrUpdate(x=>new{x.Title,x.Description,x.SubDateTime,x.OralMark,x.TotalMark},a));
            //trainers.ForEach(t=>context.Trainers.AddOrUpdate(x=>new {x.First_Name,x.Last_Name,x.Subject},t));
          
          
           
      

            context.SaveChanges();
          
        }
    }
}
