namespace RegistrationAssignmentWeb.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IRegisterUserRepository RegisterUser { get; }
        ICategoryRepository Category { get; }
        IRegisterUserEventDaysRepository RegisterUserEventDays { get; }
        void Save();
    }
}
