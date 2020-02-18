using SchoolManager.Data.Models;
using System.Collections.Generic;

namespace SchoolManager.Data.Repositories.Students
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();
    }
}
