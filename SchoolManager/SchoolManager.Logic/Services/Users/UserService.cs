using SchoolManager.Data.Models;
using SchoolManager.Data.Models.UserTypes;
using SchoolManager.Data.Repositories.Parents;
using SchoolManager.Data.Repositories.Students;
using SchoolManager.Data.Repositories.Teachers;
using SchoolManager.Data.Repositories.Users;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManager.Logic.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IParentRepository _parentRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IStudentRepository _studentRepository;

        public UserService(IUserRepository userRepository, IParentRepository parentRepository, ITeacherRepository teacherRepository, IStudentRepository studentRepository)
        {
            _userRepository = userRepository;
            _parentRepository = parentRepository;
            _teacherRepository = teacherRepository;
            _studentRepository = studentRepository;
        }

        public User SignedInUser { get; set; }


        public UserService(IUserRepository userRepository, ITeacherRepository teacherRepository, IStudentRepository studentRepository)
        {
            _userRepository = userRepository;
            _teacherRepository = teacherRepository;
            _studentRepository = studentRepository;
        }

        public bool SignIn(string email, string password)
        {
            IEnumerable<User> users = _userRepository.GetUsers();

            var user = users.SingleOrDefault(u => u.Email == email && u.Password == password);

            bool userFound = user != null;

            if (userFound)
            {
                SignedInUser = user;
            }

            return userFound;
        }

        public TUserType GetSpecificUserType<TUserType>(User user)
        {
            IEnumerable<Student> students = _studentRepository.GetStudents();
            IEnumerable<Teacher> teachers = _teacherRepository.GetTeachers();

            IEnumerable<IUser> users = students.Concat<IUser>(teachers);

            IUser specificUserType = users.FirstOrDefault(u => u.User.Id == user.Id);

            TUserType specificUser = (TUserType)specificUserType;

            return specificUser;
        }
    }
}
