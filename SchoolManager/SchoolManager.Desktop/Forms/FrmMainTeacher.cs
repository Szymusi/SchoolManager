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
    public partial class FrmMainTeacher : Form
    {
        public FrmMainTeacher(IUserService userService)
        {
            InitializeComponent();
        }
    }
}
