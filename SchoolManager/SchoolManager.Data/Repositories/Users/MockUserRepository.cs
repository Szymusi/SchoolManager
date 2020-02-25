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
            },
            new User
            {
                Id = 7,
                Name = "Albert",
                Surname = "Ceglarek",
                Email = "albert@mail.com",
                Password = "12345",
                AccountType = AccountTypes.Teacher
            },
            new User
            {
                Id = 8,
                Name = "Adam",
                Surname = "Czempiński",
                Email = "adam@mail.com",
                Password = "1234",
                AccountType = AccountTypes.Teacher
            },
            new User
            {
                Id = 9,
                Name = "Tomasz",
                Surname = "Marszałek",
                Email = "tomasz@mail.com",
                Password = "1234",
                AccountType = AccountTypes.Teacher
            },
            new User
            {
                Id = 10,
                Name = "Michał",
                Surname = "Mrozek",
                Email = "michal@mail.com",
                Password = "1234",
                AccountType = AccountTypes.Teacher
            },
            new User
            {
                Id = 11,
                Name = "Wojtek",
                Surname = "Wróz",
                Email = "wojtek@mail.com",
                Password = "1234",
                AccountType = AccountTypes.Teacher
            },
            new User
            {
                Id = 12,
                Name = "Paweł",
                Surname = "Jankowiak",
                Email = "pawel@mail.com",
                Password = "1234",
                AccountType = AccountTypes.Teacher
            },
            new User
            {
                Id = 13,
                Name = "Antoni",
                Surname = "Bielicki",
                Email = "antek@mail.com",
                Password = "1234",
                AccountType = AccountTypes.Teacher
            },
            new User
            {
                Id = 14,
                Name = "Judasz",
                Surname = "Iskariota",
                Email = "judasz@mail.com",
                Password = "1234",
                AccountType = AccountTypes.Teacher
            },
        };

        public IEnumerable<User> GetUsers()
        {
            return _users;
        }
    }
}