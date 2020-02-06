using System.Windows.Forms;

namespace SchoolManager.Desktop.Forms
{
    public partial class FrmSignIn : Form
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public FrmSignIn()
        {
            InitializeComponent();
        }

        private void BtnSignIn_MouseClick(object sender, MouseEventArgs e)
        {
            Email = TbxEmail.Text;
            Password = TbxPassword.Text;

            DialogResult = DialogResult.OK;
        }
    }
}
