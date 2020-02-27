using SchoolManager.Logic.Services.Grades;
using SchoolManager.Logic.Services.Students;
using SchoolManager.Logic.Services.Teachers;
using SchoolManager.Logic.Services.Users;
using System.Windows.Forms;

namespace SchoolManager.Desktop.Forms
{
    public partial class FrmMainTeacher : Form
    {
        private readonly IUserService _userService = new UserService();
        private readonly IStudentService _studentService = new StudentService();
        private readonly IGradeService _gradeService = new GradeService();
        private readonly ITeacherService _teacherService = new TeacherService(); 

        public FrmMainTeacher(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            string signedInUserInfo = $"Name:{_userService.SignedInUser.Name} {_userService.SignedInUser.Surname}   Role: {_userService.SignedInUser.AccountType} ";

            LblAccountInfo.Text = signedInUserInfo;
        }
    }
}
