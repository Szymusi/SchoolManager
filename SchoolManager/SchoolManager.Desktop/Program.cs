using Ninject;
using SchoolManager.Data.Repositories.Classes;
using SchoolManager.Data.Repositories.Parents;
using SchoolManager.Data.Repositories.Students;
using SchoolManager.Data.Repositories.Teachers;
using SchoolManager.Data.Repositories.Users;
using SchoolManager.Desktop.Forms;
using SchoolManager.Logic.Services.Users;
using System;
using System.Windows.Forms;


namespace SchoolManager.Desktop
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IClassRepository>().To<MockClassRepository>();
            kernel.Bind<IParentRepository>().To<MockParentRepository>();
            kernel.Bind<IStudentRepository>().To<MockStudentRepository>();
            kernel.Bind<ITeacherRepository>().To<MockTeacherRepository>();
            kernel.Bind<IUserRepository>().To<MockUserRepository>();
            kernel.Bind<IUserService>().To<UserService>();

            var _userService = kernel.Get<IUserService>();
            var _userRepository = kernel.Get<IUserRepository>();
            var _parentRepository = kernel.Get<IParentRepository>();
            var _teacherRepository = kernel.Get<ITeacherRepository>();
            var _studentRepository = kernel.Get<IStudentRepository>();
            var _classRepository = kernel.Get<IClassRepository>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmSignIn(_userService, _classRepository, _parentRepository, _teacherRepository, _userRepository, _studentRepository));
        }
    }
}