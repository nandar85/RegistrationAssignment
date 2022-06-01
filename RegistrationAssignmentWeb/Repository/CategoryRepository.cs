using RegistrationAssignmentWeb.Data;
using RegistrationAssignmentWeb.Model;

namespace RegistrationAssignmentWeb.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
