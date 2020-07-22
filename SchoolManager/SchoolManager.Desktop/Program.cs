using Ninject;
using SchoolManager.Data.Repositories.Classes;
using SchoolManager.Data.Repositories.Parents;
using SchoolManager.Data.Repositories.Students;
using SchoolManager.Data.Repositories.Teachers;
using SchoolManager.Data.Repositories.Users;
using SchoolManager.Desktop.Forms;
using SchoolManager.Desktop.Services.ComboBoxHelper;
using SchoolManager.Desktop.Services.GradesTab;
using SchoolManager.Logic.Services.Grades;
using SchoolManager.Logic.Services.Teachers;
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
            kernel.Bind<IUserService>().To<UserService>().InSingletonScope();
            kernel.Bind<IComboBoxHelperService>().To<ComboBoxHelperService>();
            kernel.Bind<IGradeService>().To<GradeService>();
            kernel.Bind<IGradesTabService>().To<GradesTabService>();
            kernel.Bind<ITeacherService>().To<TeacherService>();
            kernel.Bind<FrmMainParent>().ToSelf();
            kernel.Bind<FrmMainStudent>().ToSelf();
            kernel.Bind<FrmMainTeacher>().ToSelf();
            kernel.Bind<FrmSignIn>().ToSelf();

            Application.SetCompatibleTextRenderingDefault(false);

            var formSignIn = kernel.Get<FrmSignIn>();

            Application.EnableVisualStyles();
            
            Application.Run(formSignIn);
        }
    }
}