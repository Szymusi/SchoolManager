using SchoolManager.Data.Models;
using SchoolManager.Data.Repositories.Students;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManager.Logic.Services.Students
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository = new MockStudentRepository();

        public Student GetStudentByUser(User user)
        {
            IEnumerable<Student> students = _studentRepository.GetStudents();

            Student student = students.SingleOrDefault(s => s.User.Id == user.Id);

            return student;
        }
    }
}