using System.Collections.Generic;

namespace SchoolManager.Data.Models
{
    public class Student
    {
        public int Id { get; set; }

        public List<Grade> Grades { get; set; }
        
    }
}