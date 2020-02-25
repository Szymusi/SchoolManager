using SchoolManager.Data.Models;
using System.Collections.Generic;

namespace SchoolManager.Data.Repositories.Classes
{
    public interface IClassRepository
    {
        IEnumerable<Class> GetClasses();
    }
}
