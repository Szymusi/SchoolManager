using System.Windows.Forms;

namespace SchoolManager.Desktop.Forms
{
    public partial class FrmMain : Form
    {
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

            }
            else
            {
                Application.Exit();
            }
        }
    }
}
