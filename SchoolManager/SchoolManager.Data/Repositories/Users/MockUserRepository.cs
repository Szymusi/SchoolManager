using SchoolManager.Data.Enums;
using SchoolManager.Data.Models;
using System.Collections.Generic;

namespace SchoolManager.Data.Repositories.Users
{
    public class MockUserRepository : IUserRepository
    {
        private readonly List<User> _users = new List<User>
            {
                new User
                {
                    Id = 1,
                    Name = "Szymon",
                    Surname = "Danielak",
                    Email = "mail@mail.com",
                    Password = "1234",
                    AccountType = AccountTypes.Student
                },
                new User
                {
                    Id = 2,
                    Name = "Dominika",
                    Surname = "Lisiewicz",
                    Email = "mika@mail.com",
                    Password = "1234",
                    AccountType = AccountTypes.Teacher
                },
                new User
                {
                    Id = 3,
                    Name = "Sebastian",
                    Surname = "Szafran",
                    Email = "seba@mail.com",
                    Password = "123456",
                    AccountType = AccountTypes.Parent
                },
                new User
                {
                    Id = 4,
                    Name = "Maciej",
                    Surname = "Danielak",
                    Email = "maciej@mail.com",
                    Password = "123",
                    AccountType = AccountTypes.Student
                },
               new User
                {
                    Id = 5,
                    Name = "Piotr",
                    Surname = "Kwiaton",
                    Email = "debil@mail.com",
                    Password = "1234",
                    AccountType = AccountTypes.Student
                },
                new User
                {
                    Id = 6,
                    Name = "Jan",
                    Surname = "Kowalski",
                    Email = "jan@mail.com",
                    Password = "1234",
                    AccountType = AccountTypes.Student
                }
            };

        public IEnumerable<User> GetUsers()
        {
            return _users;
        }
    }
}