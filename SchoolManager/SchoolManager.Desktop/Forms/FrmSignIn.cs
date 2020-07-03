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
        private readonly IUserRepository _userRepository;
        private readonly IParentRepository _parentRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly IClassRepository _classRepository;
        private readonly IUserService _userService;


        public FrmSignIn(IUserService userService, IClassRepository classRepository, IParentRepository parentRepository, ITeacherRepository teacherRepository, IUserRepository userRepository, IStudentRepository studentRepository)
        {
            InitializeComponent();
            _userService = userService;
            _userRepository = userRepository;
            _parentRepository = parentRepository;
            _teacherRepository = teacherRepository;
            _studentRepository = studentRepository;
            _classRepository = classRepository;
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
                    frmMain = new FrmMainStudent(_userService,_userRepository,_parentRepository,_teacherRepository,_studentRepository,_classRepository);
                    break;
                case AccountTypes.Teacher:
                    frmMain = new FrmMainTeacher(_userService, _userRepository, _parentRepository, _teacherRepository, _studentRepository, _classRepository);
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
