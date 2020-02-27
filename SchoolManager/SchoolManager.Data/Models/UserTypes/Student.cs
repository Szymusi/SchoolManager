using System.Collections.Generic;

namespace SchoolManager.Data.Models.UserTypes
{
    public class Student : IUser
    {
        public User User { get; set; }

        public List<Grade> Grades { get; set; }

        public Student()
        {
            Grades = new List<Grade>();
        }
    }
}