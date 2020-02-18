using SchoolManager.Data.Enums;
using SchoolManager.Data.Models;
using SchoolManager.Data.Repositories.Students;
using System.Collections.Generic;

namespace SchoolManager.Logic.Services.Grades
{
    public class GradeService : IGradeService
    {
        public Dictionary<SchoolSubjects, double> CalculateWeightedAvarages(Student student)
        {
            Dictionary<SchoolSubjects, double> subjectAvarageDictionary = new Dictionary<SchoolSubjects, double>();

            return subjectAvarageDictionary;
        }

        public double CalculateAvarage(IEnumerable<Grade> grades)
        {
            double gradessum = 0;
            int weightssum = 0;

            foreach (var grade in grades)
            {
                gradessum += grade.Value;
                weightssum += grade.Weight;
            }

            double avarage = gradessum / weightssum;

            return avarage;
        }
    }
}