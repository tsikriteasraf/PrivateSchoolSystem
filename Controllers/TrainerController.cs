using PrivateScoolSystem.Views;
using PrivateScoolSystem.Views.Validations;
using System;
using System.Linq;

namespace PrivateScoolSystem.Controllers
{
   internal class TrainerController:Controller
    {

        public void ReadAllTrainers() => ViewTrainer.PrintAll(unitOfWork.Trainers.GetAll());
        public void ReadTrainersPerCourse() => ViewTrainer.PrintTrainersPerCourse(unitOfWork.Courses.GetTrainersPerCourse());
        public  void CreateTrainer()
        {
                var trainer = ViewTrainer.CreateInputTrainer();
                unitOfWork.Trainers.Add(trainer);
                unitOfWork.Complete();
        }
        public void AttachTrainerToCourse(int trainerId, int courseId)
        {
                var trainer = unitOfWork.Trainers.Get(trainerId);
                var course = unitOfWork.Courses.Get(courseId);
                course.Trainers.Add(trainer);
                trainer.Courses.Add(course);
                unitOfWork.Complete();
        }
        public void AssignTrainerToCourse()
        {
            var courseController = new CourseController();
            Console.WriteLine(@"Assign Trainer To Course");
            ReadAllTrainers();

            courseController.ReadAllCourses();

            var trainerId = Validation.IsValidLinkingTrainer(unitOfWork.Trainers.GetAll());

            var courseId = Validation.IsValidLinkingCourse(unitOfWork.Courses.GetAll());

            AttachTrainerToCourse(trainerId, courseId);
        }
        public void UpdateTrainer()
        {
                ReadAllTrainers();
                var trainerId = Validation.IsValidLinkingTrainer(unitOfWork.Trainers.GetAll());
                var trainerNew = ViewTrainer.CreateInputTrainer();
                var trainer = unitOfWork.Trainers.Find(x => x.Id == trainerId).First();
                trainer.First_Name = trainerNew.First_Name;
                trainer.Last_Name = trainerNew.Last_Name;
                trainer.Subject = trainerNew.Subject;
                unitOfWork.Trainers.ModifyEntity(trainer);
                unitOfWork.Complete();
        }
        public void DeleteTrainer()
        {
                ReadAllTrainers();
                var trainerId = Validation.IsValidLinkingTrainer(unitOfWork.Trainers.GetAll());
                var trainer = unitOfWork.Trainers.Find(x => x.Id == trainerId).First();
                unitOfWork.Trainers.Remove(trainer);
                unitOfWork.Complete();
        }
    }
}
