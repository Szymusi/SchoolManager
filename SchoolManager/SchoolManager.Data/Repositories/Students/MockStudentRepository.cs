using SchoolManager.Data.Enums;
using SchoolManager.Data.Models;
using SchoolManager.Data.Models.UserTypes;
using System.Collections.Generic;

namespace SchoolManager.Data.Repositories.Students
{
    public class MockStudentRepository : IStudentRepository
    {
        private readonly List<Student> _students = new List<Student>
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
            },
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
            },
        };

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}