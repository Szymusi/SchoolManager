using SchoolManager.Data.Enums;
using SchoolManager.Data.Models;
using System.Collections.Generic;

namespace SchoolManager.Data.Repositories.Users
{
    public class MockUserRepository : IUserRepository
    {
        private List<User> _users = new List<User>
            {
                new User
                {
                    Name = "Szymon",
                    Surname = "Danielak",
                    Email = "mail@mail.com",
                    Password = "1234",
                    AccountType = AccountTypes.Student
                },
                new User
                {
                    Name = "Dominika",
                    Surname = "Lisiewicz",
                    Email = "mika@mail.com",
                    Password = "1234",
                    AccountType = AccountTypes.Teacher
                },
                new User
                {
                    Name = "Sebastian",
                    Surname = "Szafran",
                    Email = "seba@mail.com",
                    Password = "123456",
                    AccountType = AccountTypes.Parrent
                }
            };

        public IEnumerable<User> GetUsers()
        {
            return _users;
        }
    }
}