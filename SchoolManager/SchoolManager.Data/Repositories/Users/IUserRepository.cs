using SchoolManager.Data.Models;
using System.Collections.Generic;

namespace SchoolManager.Data.Repositories.Users
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
    }
}