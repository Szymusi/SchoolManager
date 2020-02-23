using SchoolManager.Logic.Services.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
