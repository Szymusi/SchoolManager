namespace SchoolManager.Logic.Services.Users
{
    public interface IUserService
    {
        bool SignIn(string email, string password);
    }
}
