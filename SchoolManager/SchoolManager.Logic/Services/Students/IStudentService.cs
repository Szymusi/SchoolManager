using SchoolManager.Data.Models;

namespace SchoolManager.Logic.Services.Students
{
    public interface IStudentService
    {
        Student GetStudentByUser(User user);
    }
}