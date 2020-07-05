using Ninject;
using SchoolManager.Data.Enums;
using SchoolManager.Logic.Services.Users;
using System;
using System.Windows.Forms;

namespace SchoolManager.Desktop.Forms
{
    public partial class FrmSignIn : Form
    {
        private readonly IUserService _userService;
        private readonly IKernel _kernel;

        public FrmSignIn(
            IUserService userService,
            IKernel kernel)
        {
            _userService = userService;
            _kernel = kernel;
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
                    frmMain = _kernel.Get<FrmMainParent>();
                    break;
                case AccountTypes.Student:
                    frmMain = _kernel.Get<FrmMainStudent>();
                    break;
                case AccountTypes.Teacher:
                    frmMain = _kernel.Get<FrmMainTeacher>();
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
