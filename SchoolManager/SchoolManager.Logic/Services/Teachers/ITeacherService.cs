using SchoolManager.Data.Models;
using System.Collections.Generic;

namespace SchoolManager.Logic.Services.Teachers
{
    public interface ITeacherService
    {
        void AddGrade(List<Grade> grades, Grade grade);
        void DeleteGrade(List<Grade> grades, Grade grade);
        void EditGrade(List<Grade> grades, Grade oldGrade, Grade newGrade);
    }
}
