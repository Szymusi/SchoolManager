using SchoolManager.Data.Models;
using System.Collections.Generic;

namespace SchoolManager.Logic.Services.Teachers
{
    public class TeacherService : ITeacherService
    {
        public void AddGrade(List<Grade> grades, Grade grade)
        {
            grades.Add(grade);
        }

        public void DeleteGrade(List<Grade> grades, Grade grade)
        {
            grades.Remove(grade);
        }

        public void EditGrade(List<Grade> grades, Grade oldGrade, Grade newGrade)
        {
            grades.Remove(oldGrade);
            grades.Add(newGrade);
        }
    }
}
