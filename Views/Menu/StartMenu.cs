using PrivateScoolSystem.Controllers;
using System;

namespace PrivateScoolSystem.Menu
{
    class StartMenu
    {
      private readonly CourseController _courseController = new CourseController();
      private readonly StudentController _studentController = new StudentController();
      private readonly TrainerController _trainerController = new TrainerController();
      private readonly AssignmentController _assignmentController = new AssignmentController();
        public void MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"Hello user");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"Please choose one of the following");
            Console.ResetColor();
            var input ="";
            do
            {
                Console.WriteLine(@"1- View Data");
                Console.WriteLine(@"2- Create Data");
                Console.WriteLine(@"3- Update Data");
                Console.WriteLine(@"4- Delete Data");
                Console.WriteLine(@"E- To exit");
                input = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (input)
                {
                    case "1": MenuSunthetic(); break;
                    case "2": CreationMenu(); break;
                    case "3": UpdateMenu(); break;
                    case "4": DeleteMenu(); break;
                    case "E": Console.WriteLine(@"Have a nice day!"); break;
                    default: Console.WriteLine(@"Please choose a valid option"); break;
                }
            } while (input != "E");
        }
        public void MenuSunthetic()
        {
            var input = "";
            do
            {
                Console.WriteLine(@"1-All Students");
                Console.WriteLine(@"2-All Courses");
                Console.WriteLine(@"3-All Trainers");
                Console.WriteLine(@"4-All Assignments");
                Console.WriteLine(@"5-All Students Per Course");
                Console.WriteLine(@"6-All Trainers Per Course");
                Console.WriteLine(@"7-All Assignments Per Course");
                Console.WriteLine(@"8-All Assignments Per Student");
                Console.WriteLine(@"9-Students With More Than One Course");
                Console.WriteLine(@"10-Students With Assignments at a specified date");
                Console.WriteLine(@"E-To go back to main menu");
                input = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (input)
                {
                    case "1": _studentController.ReadAllStudents(); break;
                    case "2": _courseController.ReadAllCourses(); break;
                    case "3": _trainerController.ReadAllTrainers(); break;
                    case "4": _assignmentController.ReadAllAssignments(); break;
                    case "5": _studentController.ReadStudentsPerCourse(); break;
                    case "6": _trainerController.ReadTrainersPerCourse(); break;
                    case "7": _assignmentController.ReadAllAssignmentsPerCourse(); break;
                    case "8": _assignmentController.ReadAllAssignmentsPerStudent(); break;
                    case "9": _studentController.ReadStudentsMoreCourses(); break;
                    case "10": _assignmentController.ReadAllStudentsWithAssignmentsAt(); break;
                    case "E": break;

                    default: Console.WriteLine(@"Please Enter a Valid Choice"); break;
                }

            } while (input != "E");
        }
        public void CreationMenu()
        {
            var input = "";
            do
            {
                Console.WriteLine(@"1- Create Students");
                Console.WriteLine(@"2- Create Courses");
                Console.WriteLine(@"3- Create Trainers");
                Console.WriteLine(@"4- Create Assignments");
                Console.WriteLine(@"5-Assign Student To Course");
                Console.WriteLine(@"6-Assign Trainer To Course");
                Console.WriteLine(@"7-Assign Assignment To Course");
                Console.WriteLine(@"E-To go back to main menu");
                input = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (input)
                {
                    case "1": _studentController.CreateStudent(); break;
                    case "2": _courseController.CreateCourse(); break;
                    case "3": _trainerController.CreateTrainer(); break;
                    case "4": _assignmentController.CreateAssignment(); break;
                    case "5": _studentController.AssignStudentToCourse(); break;
                    case "6": _trainerController.AssignTrainerToCourse(); break;
                    case "7": _assignmentController.AssignAssignmentToCourse(); break;
                    case "E": break;
                    default: Console.WriteLine(@"Invalid Choice. Try again."); break;
                }
            } while (input != "E");
        } 
        public void UpdateMenu()
        {
            var input = "";
            do
            {
                Console.WriteLine(@"1- Update Students");
                Console.WriteLine(@"2- Update Courses");
                Console.WriteLine(@"3- Update Trainers");
                Console.WriteLine(@"4- Update Assignments");
                Console.WriteLine(@"E-To go back to main menu");
                input = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (input)
                {
                    case "1": _studentController.UpdateStudent(); break;
                    case "2": _courseController.UpdateCourse(); break;
                    case "3": _trainerController.UpdateTrainer(); break;
                    case "4": _assignmentController.UpdateAssignment(); break;
                    case "E": break;
                    default: Console.WriteLine(@"Invalid Choice. Try again."); break;
                }
            } while (input != "E");
        } 
        public void DeleteMenu()
        {
            var input = "";
            do
            {
                Console.WriteLine(@"1- Delete Students");
                Console.WriteLine(@"2- Delete Courses");
                Console.WriteLine(@"3- Delete Trainers");
                Console.WriteLine(@"4- Delete Assignments");
                Console.WriteLine(@"E-To go back to main menu");
                input = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (input)
                {
                    case "1": _studentController.DeleteStudent(); break;
                    case "2": _courseController.DeleteCourse(); break;
                    case "3": _trainerController.DeleteTrainer(); break;
                    case "4": _assignmentController.DeleteAssignment(); break;
                    case "E": break;
                    default: Console.WriteLine(@"Invalid Choice. Try again."); break;
                }
            } while (input != "E");
        }
    }
}
