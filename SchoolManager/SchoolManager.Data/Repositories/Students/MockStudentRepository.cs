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
        };

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}