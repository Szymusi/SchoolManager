using SchoolManager.Data.Models.UserTypes;
using System.Collections.Generic;

namespace SchoolManager.Data.Models
{
    public class Class
    {
        public string Name { get; set; }

        public Teacher Tutor { get; set; }

        public int Level { get; set; }

        public List<Student> Students { get; set; }

        public List<Teacher> Teachers { get; set; }

        public Class()
        {
            Students = new List<Student>();
        }
    }
}
