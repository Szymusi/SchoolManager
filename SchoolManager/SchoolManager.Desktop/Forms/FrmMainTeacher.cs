using SchoolManager.Data.Models;
using SchoolManager.Data.Models.UserTypes;
using SchoolManager.Data.Repositories.Classes;
using SchoolManager.Data.Repositories.Teachers;
using SchoolManager.Desktop.Services.ComboBoxHelper;
using SchoolManager.Logic.Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SchoolManager.Desktop.Forms
{
    public partial class FrmMainTeacher : Form
    {
        private readonly IUserService _userService = new UserService();
        private readonly IClassRepository _classRepository = new MockClassRepository();
        private readonly ITeacherRepository _teacherRepository = new MockTeacherRepository();

        private readonly IComboBoxHelperService _comboBoxHelperService = new ComboBoxHelperService();


        public FrmMainTeacher(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            Teacher teacher = _userService.GetSpecificUserType<Teacher>(_userService.SignedInUser);
            IEnumerable<Class> classes = _classRepository.GetClasses();
            IEnumerable<Class> teachersClasses = classes.Where(c => c.Teachers.Contains(teacher));

            _comboBoxHelperService.AddElementsToComboBox(CmbClasses, classes, c => c.Name);

            string signedInUserInfo = $"Name:{_userService.SignedInUser.Name} {_userService.SignedInUser.Surname}   Role: {_userService.SignedInUser.AccountType} ";

            LblAccountInfo.Text = signedInUserInfo;
            CmbClasses.SelectedIndex = 0;
        }

        private void CmbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerable<Class> classes = _classRepository.GetClasses();

            Class selectedClass = _comboBoxHelperService.GetSelectedElement(CmbClasses, classes, c => c.Name);

            _comboBoxHelperService.AddElementsToComboBox(CmbStudents, selectedClass.Students, s => $"{s.User.Name} {s.User.Surname}");

            CmbStudents.SelectedIndex = 0;
        }
    }
}
