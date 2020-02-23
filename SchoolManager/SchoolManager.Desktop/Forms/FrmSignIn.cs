using SchoolManager.Data.Enums;
using SchoolManager.Data.Models;
using SchoolManager.Logic.Services.Users;
using System;
using System.Windows.Forms;

namespace SchoolManager.Desktop.Forms
{
    public partial class FrmSignIn : Form
    {
        private readonly IUserService _userService = new UserService();

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
