using SchoolManager.Logic.Services.Users;
using System;
using System.Windows.Forms;

namespace SchoolManager.Desktop.Forms
{
    public partial class FrmMain : Form
    {
        private readonly IUserService _userService = new UserService();

        public FrmMain()
        {
            SignIn();

            InitializeComponent();

            DisplaySignedInUserInfo();
        }

        private void SignIn()
        {
            FrmSignIn frmSignIn = new FrmSignIn();

            DialogResult dialogResult = frmSignIn.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                bool signIn = _userService.SignIn(frmSignIn.Email, frmSignIn.Password);

                if (!signIn)
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void DisplaySignedInUserInfo()
        {
            string signedInUserInfo = $"Name: {_userService.SignedInUser.Name} {_userService.SignedInUser.Surname}   Role: {_userService.SignedInUser.AccountType} ";
            LblAccountInfo.Text = signedInUserInfo;
        }
    }
}
