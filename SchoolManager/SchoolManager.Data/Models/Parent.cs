using System.Collections.Generic;

namespace SchoolManager.Data.Models
{
    public class Parent
    {
        public User User { get; set; }

        public List<Student> Student { get; set; }

        public Parent()
        {
            Student = new List<Student>();
        }
    }
}