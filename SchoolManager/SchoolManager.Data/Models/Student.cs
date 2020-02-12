using System.Collections.Generic;

namespace SchoolManager.Data.Models
{
    public class Student
    {
        public User User { get; set; }

        public List<Grade> Grades { get; set; }
    }
}