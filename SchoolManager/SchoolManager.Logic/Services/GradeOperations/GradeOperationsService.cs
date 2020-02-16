using System.Collections.Generic;
using SchoolManager.Data.Models;
using SchoolManager.Logic.Services.Users;

namespace SchoolManager.Logic.Services.GradeOperations
{
    public class GradeOperationsService : IGradeOperationsService
    {
        private readonly IUserService _userService = new UserService();

        public double CalculateWeightedAvarage(IEnumerable<Grade> grades)
        {
            throw new System.NotImplementedException();
        }
    }
}