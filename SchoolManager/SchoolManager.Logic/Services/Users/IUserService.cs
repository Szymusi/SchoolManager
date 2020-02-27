using SchoolManager.Data.Models;

namespace SchoolManager.Logic.Services.Users
{
    public interface IUserService
    {
        User SignedInUser { get; }

        bool SignIn(string email, string password);

        TAccountType GetSpecificUserType<TAccountType>(User user);
    }
}
