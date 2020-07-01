using SchoolManager.Logic.Services.Users;
using System.Windows.Forms;

namespace SchoolManager.Desktop.Forms
{
    public partial class FrmMainParent : Form
    {
        public FrmMainParent(IUserService userService)
        {
            InitializeComponent();
        }
    }
}
