using Ninject;
using SchoolManager.Data.Enums;
using SchoolManager.Data.Repositories.Classes;
using SchoolManager.Data.Repositories.Parents;
using SchoolManager.Data.Repositories.Students;
using SchoolManager.Data.Repositories.Teachers;
using SchoolManager.Data.Repositories.Users;
using SchoolManager.Logic.Services.Users;
using System;
using System.Windows.Forms;

namespace SchoolManager.Desktop.Forms
{
    public partial class FrmSignIn : Form
    {
        private readonly IUserService _userService;

        public static void NinjectID()
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IClassRepository>().To<MockClassRepository>();
            kernel.Bind<IParentRepository>().To<MockParentRepository>();
            kernel.Bind<IStudentRepository>().To<MockStudentRepository>();
            kernel.Bind<ITeacherRepository>().To<MockTeacherRepository>();
            kernel.Bind<IUserRepository>().To<MockUserRepository>();
            kernel.Bind<IUserService>().To<UserService>();

            _userService = kernel.Get<IUserService>;
        }

        public FrmSignIn()
        {
            InitializeComponent();
        }

        private void BtnSignIn_MouseClick(object sender, MouseEventArgs e)
        {
            string email = TbxEmail.Text;
            string password = TbxPassword.Text;

            SignIn(email, password);

            Form frmMain = null;

            switch (_userService.SignedInUser.AccountType)
            {
                case AccountTypes.Parent:
                    frmMain = new FrmMainParent(_userService);
                    break;
                case AccountTypes.Student:
                    frmMain = new FrmMainStudent(_userService);
                    break;
                case AccountTypes.Teacher:
                    frmMain = new FrmMainTeacher(_userService);
                    break;
            }

            Hide();
            frmMain.Closed += (s, args) => Close();
            frmMain.Show();
        }

        private void SignIn(string email, string password)
        {
            bool signIn = _userService.SignIn(email, password);

            if (!signIn)
            {
                Environment.Exit(0);
            }
        }

    }
}
