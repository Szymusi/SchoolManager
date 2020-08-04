using SchoolManager.Data.Enums;
using SchoolManager.Data.Models;
using SchoolManager.Data.Models.UserTypes;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManager.Data.Repositories
{
    internal static class MockContext
    {
        public static List<Class> Classes { get; set; }
        public static List<Message> Messages { get; set; }
        public static List<Parent> Parents { get; set; }
        public static List<Student> Students { get; set; }
        public static List<Teacher> Teachers { get; set; }
        public static List<User> Users { get; set; }

        static MockContext()
        {
            Classes = new List<Class>();
            Messages = new List<Message>();
            Parents = new List<Parent>();
            Students = new List<Student>();
            Teachers = new List<Teacher>();
            Users = new List<User>();

            User SzyDan = new User
            {
                Id = 1,
                Name = "Szymon",
                Surname = "Danielak",
                Email = "mail@mail.com",
                Password = "1234",
                AccountType = AccountTypes.Student
            };
            User DomLis = new User
            {
                Id = 2,
                Name = "Dominika",
                Surname = "Lisiewicz",
                Email = "mika@mail.com",
                Password = "1234",
                AccountType = AccountTypes.Teacher
            };
            User SebSzaf = new User
            {
                Id = 3,
                Name = "Sebastian",
                Surname = "Szafran",
                Email = "seba@mail.com",
                Password = "123456",
                AccountType = AccountTypes.Parent
            };
            User MacDan = new User
            {
                Id = 4,
                Name = "Maciej",
                Surname = "Danielak",
                Email = "maciej@mail.com",
                Password = "123",
                AccountType = AccountTypes.Student
            };
            User PioKwia = new User
            {
                Id = 5,
                Name = "Piotr",
                Surname = "Kwiaton",
                Email = "debil@mail.com",
                Password = "1234",
                AccountType = AccountTypes.Student
            };
            User JanKow = new User
            {
                Id = 6,
                Name = "Jan",
                Surname = "Kowalski",
                Email = "jan@mail.com",
                Password = "1234",
                AccountType = AccountTypes.Student
            };
            User AlbCeg = new User
            {
                Id = 7,
                Name = "Albert",
                Surname = "Ceglarek",
                Email = "albert@mail.com",
                Password = "12345",
                AccountType = AccountTypes.Teacher
            };
            User AdaCze = new User
            {
                Id = 8,
                Name = "Adam",
                Surname = "Czempiński",
                Email = "adam@mail.com",
                Password = "1234",
                AccountType = AccountTypes.Teacher
            };
            User TomMar = new User
            {
                Id = 9,
                Name = "Tomasz",
                Surname = "Marszałek",
                Email = "tomasz@mail.com",
                Password = "1234",
                AccountType = AccountTypes.Teacher
            };
            User MichMroz = new User
            {
                Id = 10,
                Name = "Michał",
                Surname = "Mrozek",
                Email = "michal@mail.com",
                Password = "1234",
                AccountType = AccountTypes.Teacher
            };
            User WojWro = new User
            {
                Id = 11,
                Name = "Wojtek",
                Surname = "Wróz",
                Email = "wojtek@mail.com",
                Password = "1234",
                AccountType = AccountTypes.Teacher
            };
            User PawJan = new User
            {
                Id = 12,
                Name = "Paweł",
                Surname = "Jankowiak",
                Email = "pawel@mail.com",
                Password = "1234",
                AccountType = AccountTypes.Teacher
            };
            User AntBiel = new User
            {
                Id = 13,
                Name = "Antoni",
                Surname = "Bielicki",
                Email = "antek@mail.com",
                Password = "1234",
                AccountType = AccountTypes.Teacher
            };
            User JudIsk = new User
            {
                Id = 14,
                Name = "Judasz",
                Surname = "Iskariota",
                Email = "judasz@mail.com",
                Password = "1234",
                AccountType = AccountTypes.Teacher
            };

            Teacher DomLisTeach = new Teacher
            {
                User = DomLis,
                Profesion = SchoolSubjects.SexEducation
            };
            Teacher AlbCegTeach = new Teacher
            {
                User = AlbCeg,
                Profesion = SchoolSubjects.Chemistry
            };
            Teacher AdaCzeTeach = new Teacher
            {
                User = AdaCze,
                Profesion = SchoolSubjects.ComputerScience
            };
            Teacher TomMarTeach = new Teacher
            {
                User = TomMar,
                Profesion = SchoolSubjects.English
            };
            Teacher MichMrozTeach = new Teacher
            {
                User = MichMroz,
                Profesion = SchoolSubjects.Math
            };
            Teacher WojWroTeach = new Teacher
            {
                User = WojWro,
                Profesion = SchoolSubjects.PE
            };
            Teacher PawJanTeach = new Teacher
            {
                User = PawJan,
                Profesion = SchoolSubjects.Polish
            };
            Teacher AntBielTeach = new Teacher
            {
                User = AntBiel,
                Profesion = SchoolSubjects.Polish
            };

            Student PioKwiaStud = new Student
            {
                User = PioKwia,
                Grades = new List<Grade>
                {
                    new Grade
                    {
                        Id = 77,
                        SchoolSubject = SchoolSubjects.Chemistry,
                        Value = 2,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 78,
                        SchoolSubject = SchoolSubjects.Chemistry,
                        Value = 1,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 79,
                        SchoolSubject = SchoolSubjects.Chemistry,
                        Value = 3,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 80,
                        SchoolSubject = SchoolSubjects.Chemistry,
                        Value = 2,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 81,
                        SchoolSubject = SchoolSubjects.ComputerScience,
                        Value = 3,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 82,
                        SchoolSubject = SchoolSubjects.ComputerScience,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 83,
                        SchoolSubject = SchoolSubjects.ComputerScience,
                        Value = 4,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 84,
                        SchoolSubject = SchoolSubjects.ComputerScience,
                        Value = 3,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 85,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 4,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 86,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 3,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 87,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 2,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 88,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 4,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 89,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 90,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 4,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 91,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 2,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 92,
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 3,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 93,
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 4,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 94,
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 2,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 95,
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 4,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 96,
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 2,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 97,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 3,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 98,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 4,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 99,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 2,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 100,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 4,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 101,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 102,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 3,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 103,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 4,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 104,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 105,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 3,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 106,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 4,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 107,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 3,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 108,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 2,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 109,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 4,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 110,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 5,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 111,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 4,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 112,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 3,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 113,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 3,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 114,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 5,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                }
            };
            Student JanKowStud = new Student
            {
                User = JanKow,
                Grades = new List<Grade>
                {
                    new Grade
                    {
                        Id = 115,
                        SchoolSubject = SchoolSubjects.Chemistry,
                        Value = 4,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 116,
                        SchoolSubject = SchoolSubjects.Chemistry,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 117,
                        SchoolSubject = SchoolSubjects.Chemistry,
                        Value = 4,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 118,
                        SchoolSubject = SchoolSubjects.Chemistry,
                        Value = 2,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 119,
                        SchoolSubject = SchoolSubjects.ComputerScience,
                        Value = 6,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 120,
                        SchoolSubject = SchoolSubjects.ComputerScience,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 121,
                        SchoolSubject = SchoolSubjects.ComputerScience,
                        Value = 4,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 122,
                        SchoolSubject = SchoolSubjects.ComputerScience,
                        Value = 3,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 123,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 5,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 124,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 125,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 5,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 126,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 6,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 127,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 128,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 3,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 129,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 5,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 130,
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 4,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 131,
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 2,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 132,
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 3,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 133,
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 5,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 134,
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 2,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 135,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 5,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 136,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 137,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 5,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 138,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 5,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 139,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 140,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 3,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 141,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 5,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 142,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 143,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 3,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 144,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 5,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 145,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 146,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 5,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 147,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 5,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 148,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 3,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 149,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 4,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 150,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 2,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 151,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 5,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 152,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 3,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                }
            };
            Student SzyDanStud = new Student
            {
                User = SzyDan,
                Grades = new List<Grade>
                {
                    new Grade
                    {
                        Id = 1,
                        SchoolSubject = SchoolSubjects.Chemistry,
                        Value = 3,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 2,
                        SchoolSubject = SchoolSubjects.Chemistry,
                        Value = 1,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 3,
                        SchoolSubject = SchoolSubjects.Chemistry,
                        Value = 3,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 4,
                        SchoolSubject = SchoolSubjects.Chemistry,
                        Value = 5,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 5,
                        SchoolSubject = SchoolSubjects.ComputerScience,
                        Value = 4,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 6,
                        SchoolSubject = SchoolSubjects.ComputerScience,
                        Value = 3,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 7,
                        SchoolSubject = SchoolSubjects.ComputerScience,
                        Value = 2,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 8,
                        SchoolSubject = SchoolSubjects.ComputerScience,
                        Value = 6,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 9,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 3,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 10,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 1,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 11,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 3,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 12,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 5,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 13,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 3,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 14,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 6,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 15,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 3,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 16,
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 1,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 17,
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 3,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 18,
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 5,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 19,
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 3,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 20,
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 6,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 21,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 4,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 22,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 6,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 23,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 4,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 24,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 3,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 25,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 1,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 26,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 6,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 27,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 2,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 28,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 4,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 29,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 2,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 30,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 1,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 31,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 5,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 32,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 3,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 33,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 2,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 34,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 6,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 35,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 1,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 36,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 4,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 37,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 38,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 3,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                }
            };
            Student MacDanStud = new Student
            {
                User = MacDan,
                Grades = new List<Grade>
                {
                    new Grade
                    {
                        Id = 39,
                        SchoolSubject = SchoolSubjects.Chemistry,
                        Value = 3,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 40,
                        SchoolSubject = SchoolSubjects.Chemistry,
                        Value = 5,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 41,
                        SchoolSubject = SchoolSubjects.Chemistry,
                        Value = 1,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 42,
                        SchoolSubject = SchoolSubjects.Chemistry,
                        Value = 6,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 43,
                        SchoolSubject = SchoolSubjects.ComputerScience,
                        Value = 3,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 44,
                        SchoolSubject = SchoolSubjects.ComputerScience,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 45,
                        SchoolSubject = SchoolSubjects.ComputerScience,
                        Value = 5,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 46,
                        SchoolSubject = SchoolSubjects.ComputerScience,
                        Value = 3,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 47,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 2,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 48,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 4,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 49,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 6,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 50,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 4,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 51,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 52,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 1,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 53,
                        SchoolSubject = SchoolSubjects.English,
                        Value = 2,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 54,
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 4,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 55,
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 5,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 56,
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 6,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 57,
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 58,
                        SchoolSubject = SchoolSubjects.Math,
                        Value = 3,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 59,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 5,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 60,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 2,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 61,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 3,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 62,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 2,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 63,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 5,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 64,
                        SchoolSubject = SchoolSubjects.PE,
                        Value = 3,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 65,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 4,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 66,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 5,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 67,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 4,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 68,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 5,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 69,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 3,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 70,
                        SchoolSubject = SchoolSubjects.Polish,
                        Value = 4,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 71,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 5,
                        Weight = 2,
                        Task = "Homework",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 72,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 3,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 73,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 4,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID OK"
                    },
                    new Grade
                    {
                        Id = 74,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 2,
                        Weight = 1,
                        Task = "Activity",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 75,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 4,
                        Weight = 2,
                        Task = "Exam",
                        Comment = "DID GOOD"
                    },
                    new Grade
                    {
                        Id = 76,
                        SchoolSubject = SchoolSubjects.SexEducation,
                        Value = 5,
                        Weight = 2,
                        Task = "Quiz",
                        Comment = "DID GOOD"
                    },
                }
            };

            Class Class1a = new Class
            {
                Name = "1a",
                Level = 1,
                Tutor = MichMrozTeach,
                Teachers = new List<Teacher>
                {
                    DomLisTeach,
                    AlbCegTeach,
                    AdaCzeTeach,
                    TomMarTeach,
                    MichMrozTeach,
                },
                Students = new List<Student>
                {
                    PioKwiaStud,
                    JanKowStud,
                }
            };
            Class Class2a = new Class
            {
                Name = "2a",
                Level = 2,
                Tutor = DomLisTeach,
                Teachers = new List<Teacher>
                {
                    AlbCegTeach,
                    AdaCzeTeach,
                    TomMarTeach,
                    MichMrozTeach,
                    WojWroTeach,
                    PawJanTeach,
                    AntBielTeach,
                },
                Students = new List<Student>
                {
                    SzyDanStud,
                    MacDanStud,
                }
            };

            Message message1 = new Message
            {
                Id = 1,
                Sender = DomLis,
                Receiver = SzyDan,
                Title = "Pierwszy mail",
                Content = "DUUUUUUUUUUUUUUPA",
                Deleted = false
            };
            Message message2 = new Message
            {
                Id = 2,
                Sender = JanKow,
                Receiver = DomLis,
                Title = "Drugi mail",
                Content = "Mail na ważny temat",
                Deleted = false
            };
            Message message3 = new Message
            {
                Id = 3,
                Sender = PawJan,
                Receiver = DomLis,
                Title = "Kolejny mail mail",
                Content = "Mail na mniej ważny temat",
                Deleted = false
            };
            Message message4 = new Message
            {
                Id = 4,
                Sender = SzyDan,
                Receiver = DomLis,
                Title = "Lowki kiski",
                Content = "Lowciam cię na 100%",
                Deleted = false
            };
            Message message5 = new Message
            {
                Id = 2,
                Sender = WojWro,
                Receiver = DomLis,
                Title = "Jakiś spam do kosza",
                Content = "Ten mail powinien być w koszu",
                Deleted = true
            };


            Classes.Add(Class1a);
            Classes.Add(Class2a);

            Students.Add(SzyDanStud);
            Students.Add(MacDanStud);
            Students.Add(PioKwiaStud);
            Students.Add(JanKowStud);

            Teachers.Add(DomLisTeach);
            Teachers.Add(AlbCegTeach);
            Teachers.Add(AdaCzeTeach);
            Teachers.Add(TomMarTeach);
            Teachers.Add(MichMrozTeach);
            Teachers.Add(WojWroTeach);
            Teachers.Add(PawJanTeach);
            Teachers.Add(AntBielTeach);

            Users.Add(SzyDan);
            Users.Add(DomLis);
            Users.Add(SebSzaf);
            Users.Add(MacDan);
            Users.Add(PioKwia);
            Users.Add(JanKow);
            Users.Add(AlbCeg);
            Users.Add(AdaCze);
            Users.Add(TomMar);
            Users.Add(MichMroz);
            Users.Add(WojWro);
            Users.Add(PawJan);
            Users.Add(AntBiel);
            Users.Add(JudIsk);

            Messages.Add(message1);
            Messages.Add(message2);
            Messages.Add(message3);
            Messages.Add(message4);
            Messages.Add(message5);
        }
    }
}
