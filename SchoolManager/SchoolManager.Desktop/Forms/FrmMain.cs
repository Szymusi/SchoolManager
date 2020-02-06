using SchoolManager.Logic.Services.Users;
using System;
using System.Windows.Forms;

namespace SchoolManager.Desktop.Forms
{
    public partial class FrmMain : Form
    {
        private IUserService _userService = new UserService();
        public FrmMain()
        {
            SignIn();

            InitializeComponent();
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
    }
}
