using SchoolManager.Data.Enums;

namespace SchoolManager.Data.Models.UserTypes
{
    public class Teacher : IUser
    {
        public User User { get; set; } 

        public SchoolSubjects Profesion { get; set; }
    }
}