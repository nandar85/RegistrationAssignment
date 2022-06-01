using RegistrationAssignmentWeb.Data;
using RegistrationAssignmentWeb.Model;

namespace RegistrationAssignmentWeb.Repository
{ 
    public class RegisterUserEventDaysRepository : Repository<RegisterUserEventDays>, IRegisterUserEventDaysRepository
    {
        private readonly ApplicationDbContext _db;

        public RegisterUserEventDaysRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
