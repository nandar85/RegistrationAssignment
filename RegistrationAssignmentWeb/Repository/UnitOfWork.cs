using RegistrationAssignmentWeb.Data;

namespace RegistrationAssignmentWeb.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            RegisterUser = new RegisterUserRepository(_db);
            Category = new CategoryRepository(_db);
            RegisterUserEventDays=new RegisterUserEventDaysRepository(_db);

        }

        public IRegisterUserRepository RegisterUser { get; private set; }
        public ICategoryRepository Category { get; private set; }
        public IRegisterUserEventDaysRepository RegisterUserEventDays { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
