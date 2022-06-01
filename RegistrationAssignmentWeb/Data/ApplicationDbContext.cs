using Microsoft.EntityFrameworkCore;
using RegistrationAssignmentWeb.Model;

namespace RegistrationAssignmentWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<RegisterUser> RegisterUser { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<RegisterUserEventDays> RegisterUserEventDays { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure domain classes using modelBuilder here   
            modelBuilder.Entity<RegisterUser>()
              .HasData(
               new RegisterUser()
               {
                   Id = 1,
                   Name = "test1",
                   Email = "test1@gmail.com",
                   Gender = 'M',
                   RegisterDate = Convert.ToDateTime("02/02/2023"),
                   InterestArea = 160,
                   AdditionalRequest = "request1"

               },
                new RegisterUser()
                {
                    Id = 2,
                    Name = "test2",
                    Email = "test2@gmail.com",
                    Gender = 'F',
                    RegisterDate = Convert.ToDateTime("26/05/2023"),
                    InterestArea = 37,
                    AdditionalRequest = "request2"
                },
                new RegisterUser()
                {
                    Id = 3,
                    Name = "test3",
                    Email = "test3@gmail.com",
                    Gender = 'F',
                    RegisterDate = Convert.ToDateTime("26/05/2023"),
                    InterestArea = 37,
                    AdditionalRequest = "request3"
                }
                    );
            modelBuilder.Entity<RegisterUserEventDays>()
             .HasData(
              new RegisterUserEventDays()
              {
                  RegisterUserEventDaysId = 1,
                  RegisterUserId = 1,
                  Days = "Day 1"

              },
               new RegisterUserEventDays()
               {
                   RegisterUserEventDaysId = 2,
                   RegisterUserId = 2,
                   Days = "Day 1"

               },
                new RegisterUserEventDays()
                {
                    RegisterUserEventDaysId = 3,
                    RegisterUserId = 3,
                    Days = "Day 1"

                }
                   );

        }
    }
}
