using SchoolManager.Data.Models;
using SchoolManager.Data.Repositories.Users;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManager.Logic.Services.Users
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository = new MockUserRepository();

        public User SignedInUser { get; set; }

        public bool SignIn(string email, string password)
        {
            IEnumerable<User> users= _userRepository.GetUsers();

            var user = users.SingleOrDefault(u => u.Email == email && u.Password == password);

            bool userFound = user != null;

            if (userFound)
            {
                SignedInUser = user;
            }

            return userFound;
        }
    }
}