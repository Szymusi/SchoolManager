using SchoolManager.Data.Models;
using SchoolManager.Data.Repositories.Students;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManager.Logic.Services.Students
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
    }
}