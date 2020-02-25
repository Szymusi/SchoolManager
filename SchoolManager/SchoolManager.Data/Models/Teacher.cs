using SchoolManager.Data.Enums;
using System.Collections.Generic;

namespace SchoolManager.Data.Models
{
    public class Teacher
    {
        public User User { get; set; } 

        public SchoolSubjects Profesion { get; set; }
    }
}