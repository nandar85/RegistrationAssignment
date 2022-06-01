using RegistrationAssignmentWeb.Data;
using RegistrationAssignmentWeb.Model;

namespace RegistrationAssignmentWeb.Repository
{
    public class RegisterUserRepository : Repository<RegisterUser>, IRegisterUserRepository
    {
        private readonly ApplicationDbContext _db;

        public RegisterUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
