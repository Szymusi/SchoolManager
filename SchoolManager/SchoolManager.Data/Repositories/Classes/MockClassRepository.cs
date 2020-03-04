using SchoolManager.Data.Enums;
using SchoolManager.Data.Models;
using SchoolManager.Data.Models.UserTypes;
using System.Collections.Generic;

namespace SchoolManager.Data.Repositories.Classes
{
    public class MockClassRepository : IClassRepository
    {
        private readonly List<Class> _classes = new List<Class>
        {
            new Class
            {
                Name = "1a",
                Level = 1,
                Tutor = new Teacher
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
                Teachers = new List<Teacher>
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
                },
                Students = new List<Student>
                {
                    new Student
                        {
                            User = new User
                            {
                                Id = 5,
                                Name = "Piotr",
                                Surname = "Kwiaton",
                                Email = "debil@mail.com",
                                Password = "1234",
                                AccountType = AccountTypes.Student
                            },
                            Grades = new List<Grade>
                            {
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.Chemistry,
                                    Value = 2,
                                    Weight = 2,
                                    Task = "Homework",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.Chemistry,
                                    Value = 1,
                                    Weight = 2,
                                    Task = "Exam",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.Chemistry,
                                    Value = 3,
                                    Weight = 2,
                                    Task = "Quiz",
                                    Comment = "DID OK"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.Chemistry,
                                    Value = 2,
                                    Weight = 1,
                                    Task = "Activity",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.ComputerScience,
                                    Value = 3,
                                    Weight = 2,
                                    Task = "Homework",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.ComputerScience,
                                    Value = 2,
                                    Weight = 2,
                                    Task = "Exam",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.ComputerScience,
                                    Value = 4,
                                    Weight = 2,
                                    Task = "Quiz",
                                    Comment = "DID OK"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.ComputerScience,
                                    Value = 3,
                                    Weight = 1,
                                    Task = "Activity",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.English,
                                    Value = 4,
                                    Weight = 2,
                                    Task = "Homework",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.English,
                                    Value = 3,
                                    Weight = 2,
                                    Task = "Exam",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.English,
                                    Value = 2,
                                    Weight = 2,
                                    Task = "Quiz",
                                    Comment = "DID OK"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.English,
                                    Value = 4,
                                    Weight = 1,
                                    Task = "Activity",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.English,
                                    Value = 2,
                                    Weight = 2,
                                    Task = "Exam",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.English,
                                    Value = 4,
                                    Weight = 2,
                                    Task = "Quiz",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.English,
                                    Value = 2,
                                    Weight = 2,
                                    Task = "Homework",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.Math,
                                    Value = 3,
                                    Weight = 2,
                                    Task = "Exam",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.Math,
                                    Value = 4,
                                    Weight = 2,
                                    Task = "Quiz",
                                    Comment = "DID OK"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.Math,
                                    Value = 2,
                                    Weight = 1,
                                    Task = "Activity",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.Math,
                                    Value = 4,
                                    Weight = 2,
                                    Task = "Exam",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.Math,
                                    Value = 2,
                                    Weight = 2,
                                    Task = "Quiz",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.PE,
                                    Value = 3,
                                    Weight = 2,
                                    Task = "Homework",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.PE,
                                    Value = 4,
                                    Weight = 2,
                                    Task = "Exam",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.PE,
                                    Value = 2,
                                    Weight = 2,
                                    Task = "Quiz",
                                    Comment = "DID OK"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.PE,
                                    Value = 4,
                                    Weight = 1,
                                    Task = "Activity",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.PE,
                                    Value = 2,
                                    Weight = 2,
                                    Task = "Exam",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.PE,
                                    Value = 3,
                                    Weight = 2,
                                    Task = "Quiz",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.Polish,
                                    Value = 4,
                                    Weight = 2,
                                    Task = "Homework",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.Polish,
                                    Value = 2,
                                    Weight = 2,
                                    Task = "Exam",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.Polish,
                                    Value = 3,
                                    Weight = 2,
                                    Task = "Quiz",
                                    Comment = "DID OK"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.Polish,
                                    Value = 4,
                                    Weight = 1,
                                    Task = "Activity",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.Polish,
                                    Value = 3,
                                    Weight = 2,
                                    Task = "Exam",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.Polish,
                                    Value = 2,
                                    Weight = 2,
                                    Task = "Quiz",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.SexEducation,
                                    Value = 4,
                                    Weight = 2,
                                    Task = "Homework",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.SexEducation,
                                    Value = 5,
                                    Weight = 2,
                                    Task = "Exam",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.SexEducation,
                                    Value = 4,
                                    Weight = 2,
                                    Task = "Quiz",
                                    Comment = "DID OK"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.SexEducation,
                                    Value = 3,
                                    Weight = 1,
                                    Task = "Activity",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.SexEducation,
                                    Value = 3,
                                    Weight = 2,
                                    Task = "Exam",
                                    Comment = "DID GOOD"
                                },
                                new Grade
                                {
                                    SchoolSubject = SchoolSubjects.SexEducation,
                                    Value = 5,
                                    Weight = 2,
                                    Task = "Quiz",
                                    Comment = "DID GOOD"
                                },
                            }
                        },
                    new Student
            {
                User = new User
                {
                    Id = 6,
                    Name = "Jan",
                    Surname = "Kowalski",
                    Email = "jan@mail.com",
                    Password = "1234",
                    AccountType = AccountTypes.Student
                },
                Grades = new List<Grade>
                {
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.Chemistry,
                        Value = 4,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.Chemistry,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.Chemistry,
                        Value = 4,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.Chemistry,
                        Value = 2,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.ComputerScience,
                        Value = 6,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.ComputerScience,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.ComputerScience,
                        Value = 4,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.ComputerScience,
                        Value = 3,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.English,
                        Value = 5,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.English,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.English,
                        Value = 5,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.English,
                        Value = 6,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.English,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.English,
                        Value = 3,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.English,
                        Value = 5,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 4,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 2,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 3,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 5,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 2,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 5,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 5,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 5,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 3,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 5,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 3,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 5,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 5,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 5,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 3,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 4,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 2,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 5,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 3,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                }
            },
                }
            },
            new Class
            {
                Name = "2a",
                Level = 2,
                Tutor = new Teacher
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
                Teachers = new List<Teacher>
                {
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
                },
                Students = new List<Student>
                {
                    new Student
                    {
                        User = new User
                        {
                            Id = 1,
                            Name = "Szymon",
                            Surname = "Danielak",
                            Email = "mail@mail.com",
                            Password = "1234",
                            AccountType = AccountTypes.Student
                        },
                        Grades = new List<Grade>
                        {
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Chemistry,
                                Value = 3,
                                Weight = 2,
                                Task = "Homework",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Chemistry,
                                Value = 1,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Chemistry,
                                Value = 3,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID OK"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Chemistry,
                                Value = 5,
                                Weight = 1,
                                Task = "Activity",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.ComputerScience,
                                Value = 4,
                                Weight = 2,
                                Task = "Homework",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.ComputerScience,
                                Value = 3,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.ComputerScience,
                                Value = 2,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID OK"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.ComputerScience,
                                Value = 6,
                                Weight = 1,
                                Task = "Activity",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.English,
                                Value = 3,
                                Weight = 2,
                                Task = "Homework",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.English,
                                Value = 1,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.English,
                                Value = 3,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID OK"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.English,
                                Value = 5,
                                Weight = 1,
                                Task = "Activity",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.English,
                                Value = 3,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.English,
                                Value = 6,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.English,
                                Value = 3,
                                Weight = 2,
                                Task = "Homework",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Math,
                                Value = 1,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Math,
                                Value = 3,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID OK"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Math,
                                Value = 5,
                                Weight = 1,
                                Task = "Activity",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Math,
                                Value = 3,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Math,
                                Value = 6,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.PE,
                                Value = 4,
                                Weight = 2,
                                Task = "Homework",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.PE,
                                Value = 6,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.PE,
                                Value = 4,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID OK"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.PE,
                                Value = 3,
                                Weight = 1,
                                Task = "Activity",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.PE,
                                Value = 1,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.PE,
                                Value = 6,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Polish,
                                Value = 2,
                                Weight = 2,
                                Task = "Homework",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Polish,
                                Value = 4,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Polish,
                                Value = 2,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID OK"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Polish,
                                Value = 1,
                                Weight = 1,
                                Task = "Activity",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Polish,
                                Value = 5,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Polish,
                                Value = 3,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.SexEducation,
                                Value = 2,
                                Weight = 2,
                                Task = "Homework",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.SexEducation,
                                Value = 6,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.SexEducation,
                                Value = 1,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID OK"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.SexEducation,
                                Value = 4,
                                Weight = 1,
                                Task = "Activity",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.SexEducation,
                                Value = 2,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.SexEducation,
                                Value = 3,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID GOOD"
                            },
                        }
                    },
                    new Student
                    {
                        User = new User
                        {
                            Id = 4,
                            Name = "Maciej",
                            Surname = "Danielak",
                            Email = "maciej@mail.com",
                            Password = "123",
                            AccountType = AccountTypes.Student
                        },
                        Grades = new List<Grade>
                        {
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Chemistry,
                                Value = 3,
                                Weight = 2,
                                Task = "Homework",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Chemistry,
                                Value = 5,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Chemistry,
                                Value = 1,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID OK"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Chemistry,
                                Value = 6,
                                Weight = 1,
                                Task = "Activity",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.ComputerScience,
                                Value = 3,
                                Weight = 2,
                                Task = "Homework",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.ComputerScience,
                                Value = 2,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.ComputerScience,
                                Value = 5,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID OK"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.ComputerScience,
                                Value = 3,
                                Weight = 1,
                                Task = "Activity",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.English,
                                Value = 2,
                                Weight = 2,
                                Task = "Homework",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.English,
                                Value = 4,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.English,
                                Value = 6,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID OK"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.English,
                                Value = 4,
                                Weight = 1,
                                Task = "Activity",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.English,
                                Value = 2,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.English,
                                Value = 1,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.English,
                                Value = 2,
                                Weight = 2,
                                Task = "Homework",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Math,
                                Value = 4,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Math,
                                Value = 5,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID OK"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Math,
                                Value = 6,
                                Weight = 1,
                                Task = "Activity",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Math,
                                Value = 2,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Math,
                                Value = 3,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.PE,
                                Value = 5,
                                Weight = 2,
                                Task = "Homework",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.PE,
                                Value = 2,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.PE,
                                Value = 3,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID OK"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.PE,
                                Value = 2,
                                Weight = 1,
                                Task = "Activity",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.PE,
                                Value = 5,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.PE,
                                Value = 3,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Polish,
                                Value = 4,
                                Weight = 2,
                                Task = "Homework",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Polish,
                                Value = 5,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Polish,
                                Value = 4,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID OK"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Polish,
                                Value = 5,
                                Weight = 1,
                                Task = "Activity",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Polish,
                                Value = 3,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.Polish,
                                Value = 4,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.SexEducation,
                                Value = 5,
                                Weight = 2,
                                Task = "Homework",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.SexEducation,
                                Value = 3,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.SexEducation,
                                Value = 4,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID OK"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.SexEducation,
                                Value = 2,
                                Weight = 1,
                                Task = "Activity",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.SexEducation,
                                Value = 4,
                                Weight = 2,
                                Task = "Exam",
                                Comment = "DID GOOD"
                            },
                            new Grade
                            {
                                SchoolSubject = SchoolSubjects.SexEducation,
                                Value = 5,
                                Weight = 2,
                                Task = "Quiz",
                                Comment = "DID GOOD"
                            },
                        }
                    },
                }
            },
        };

        public IEnumerable<Class> GetClasses()
        {
            return _classes;
        }
    }
}
