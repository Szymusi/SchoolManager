using SchoolManager.Data.Enums;
using SchoolManager.Data.Models;
using System.Collections.Generic;

namespace SchoolManager.Logic.Services.Grades
{
    public interface IGradeService
    {
        Dictionary<SchoolSubjects, double> CalculateWeightedAvarages(Student student);

        double CalculateAvarage(IEnumerable<Grade> grades);
    }
}