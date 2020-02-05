using SchoolManager.Data.Models;
using System.Collections.Generic;

namespace SchoolManager.Logic.Services.GradeOperations
{
    public interface IGradeOperationsService
    {
        double CalculateWeightedAvarage(IEnumerable<Grade> grades);
    }
}