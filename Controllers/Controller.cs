using PrivateScoolSystem.Persistence;


namespace PrivateScoolSystem.Controllers
{
   internal class Controller
    {
        public  UnitOfWork unitOfWork {get;} = new UnitOfWork(new PrivateSchoolDbContext());
    }
}
