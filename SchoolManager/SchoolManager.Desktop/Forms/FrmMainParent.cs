using SchoolManager.Data.Repositories.Classes;
using SchoolManager.Data.Repositories.Parents;
using SchoolManager.Data.Repositories.Students;
using SchoolManager.Data.Repositories.Teachers;
using SchoolManager.Data.Repositories.Users;
using SchoolManager.Desktop.Services.ComboBoxHelper;
using SchoolManager.Logic.Services.Grades;
using SchoolManager.Logic.Services.Users;
using System.Windows.Forms;

namespace SchoolManager.Desktop.Forms
{
    public partial class FrmMainParent : Form
    {
        private readonly IUserService _userService;
        private readonly IUserRepository _userRepository;
        private readonly IParentRepository _parentRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly IClassRepository _classRepository;
        private readonly IGradeService _gradeService;
        private readonly IComboBoxHelperService _comboBoxHelperService;

        public FrmMainParent(
            IGradeService gradeService, 
            IComboBoxHelperService comboBoxHelperService,
            IUserService userService, 
            IUserRepository userRepository,
            IParentRepository parentRepository, 
            ITeacherRepository teacherRepository,
            IStudentRepository studentRepository, 
            IClassRepository classRepository)
        {
            InitializeComponent();
        }
    }
}
