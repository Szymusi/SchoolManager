using SchoolManager.Data.Models;
using System.Collections.Generic;

namespace SchoolManager.Data.Repositories.Teachers
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetTeachers();
    }
}
