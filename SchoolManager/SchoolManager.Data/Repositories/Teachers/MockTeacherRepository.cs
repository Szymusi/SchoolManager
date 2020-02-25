using SchoolManager.Data.Enums;
using SchoolManager.Data.Models;
using System.Collections.Generic;

namespace SchoolManager.Data.Repositories.Teachers
{
    class MockTeacherRepository : ITeacherRepository
    {
        private readonly List<Teacher> _teachers = new List<Teacher>
        {
            new Teacher
            {
                User = new User
                {
                    Id = 2,
                    Name = "Dominika",
                    Surname = "Lisiewicz",
                    Email = "mika@mail.com",
                    Password = "1234",
                    AccountType = AccountTypes.Teacher
                },
                Profesion = SchoolSubjects.SexEducation
            },
            new Teacher
            {
                User = new User
                {
                    Id = 7,
                    Name = "Albert",
                    Surname = "Ceglarek",
                    Email = "albert@mail.com",
                    Password = "12345",
                    AccountType = AccountTypes.Teacher
                },
                Profesion = SchoolSubjects.Chemistry
            },
            new Teacher
            {
                User = new User
                {
                    Id = 8,
                    Name = "Adam",
                    Surname = "Czempiński",
                    Email = "adammail.com",
                    Password = "1234",
                    AccountType = AccountTypes.Teacher
                },
                Profesion = SchoolSubjects.ComputerScience
            },
            new Teacher
            {
                User = new User
                {
                    Id = 9,
                    Name = "Tomasz",
                    Surname = "Marszałek",
                    Email = "tomasz@mail.com",
                    Password = "1234",
                    AccountType = AccountTypes.Teacher
                },
                Profesion = SchoolSubjects.English
            },
            new Teacher
            {
                User = new User
                {
                    Id = 10,
                    Name = "Michał",
                    Surname = "Mrozek",
                    Email = "michal@mail.com",
                    Password = "1234",
                    AccountType = AccountTypes.Teacher
                },
                Profesion = SchoolSubjects.Math
            },
            new Teacher
            {
                User = new User
                {
                    Id = 11,
                    Name = "Wojtek",
                    Surname = "Wróz",
                    Email = "wojtek@mail.com",
                    Password = "1234",
                    AccountType = AccountTypes.Teacher
                },
                Profesion = SchoolSubjects.PE
            },
            new Teacher
            {
                User = new User
                {
                    Id = 12,
                    Name = "Paweł",
                    Surname = "Jankowiak",
                    Email = "pawel@mail.com",
                    Password = "1234",
                    AccountType = AccountTypes.Teacher
                },
                Profesion = SchoolSubjects.Polish
            },
            new Teacher
            {
                User = new User
                {
                    Id = 13,
                    Name = "Antoni",
                    Surname = "Bielicki",
                    Email = "antek@mail.com",
                    Password = "1234",
                    AccountType = AccountTypes.Teacher
                },
                Profesion = SchoolSubjects.Math
            },
            new Teacher
            {
                User = new User
                {
                    Id = 13,
                    Name = "Antoni",
                    Surname = "Bielicki",
                    Email = "antek@mail.com",
                    Password = "1234",
                    AccountType = AccountTypes.Teacher
                },
                Profesion = SchoolSubjects.English
            },
        };

        public IEnumerable<Teacher> GetTeachers()
        {
            return _teachers;
        }
    }
}
