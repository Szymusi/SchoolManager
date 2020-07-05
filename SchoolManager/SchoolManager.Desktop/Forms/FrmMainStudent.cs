using SchoolManager.Data.Enums;
using SchoolManager.Data.Models;
using SchoolManager.Data.Models.UserTypes;
using SchoolManager.Data.Repositories.Classes;
using SchoolManager.Data.Repositories.Parents;
using SchoolManager.Data.Repositories.Students;
using SchoolManager.Data.Repositories.Teachers;
using SchoolManager.Data.Repositories.Users;
using SchoolManager.Desktop.Services.ComboBoxHelper;
using SchoolManager.Logic.Services.Grades;
using SchoolManager.Logic.Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SchoolManager.Desktop.Forms
{
    public partial class FrmMainStudent : Form
    {
        private readonly IUserService _userService;
        private readonly IUserRepository _userRepository;
        private readonly IParentRepository _parentRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly IClassRepository _classRepository;
        private readonly IGradeService _gradeService;
        private readonly IComboBoxHelperService _comboBoxHelperService;

        public FrmMainStudent(
            IGradeService gradeService, 
            IComboBoxHelperService comboBoxHelperService,
            IUserService userService, 
            IUserRepository userRepository,
            IParentRepository parentRepository, 
            ITeacherRepository teacherRepository,
            IStudentRepository studentRepository, 
            IClassRepository classRepository)
        {
            _gradeService = gradeService;
            _comboBoxHelperService = comboBoxHelperService;
            _userService = userService;
            _userRepository = userRepository;
            _parentRepository = parentRepository;
            _teacherRepository = teacherRepository;
            _studentRepository = studentRepository;
            _classRepository = classRepository;

            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            Student student = _userService.GetSpecificUserType<Student>(_userService.SignedInUser);

            string signedInUserInfo = $"Name: {_userService.SignedInUser.Name} {_userService.SignedInUser.Surname}   Role: {_userService.SignedInUser.AccountType} ";
            LblAccountInfo.Text = signedInUserInfo;

            IEnumerable<SchoolSubjects> schoolSubjects = (IEnumerable<SchoolSubjects>)Enum.GetValues(typeof(SchoolSubjects));

            foreach (var schoolSubject in schoolSubjects)
            {
                IEnumerable<Grade> subjectGrades = student.Grades.Where(g => g.SchoolSubject == schoolSubject);

                double avarage = _gradeService.CalculateAvarage(subjectGrades);

                IEnumerable<double> gradeValues = subjectGrades.Select(g => g.Value);

                string gradesString = string.Join(", ", gradeValues);

                GridGrades.Rows.Add(schoolSubject, gradesString, avarage);
            }

            GridGrades_CellMouseClick(GridGrades, new DataGridViewCellMouseEventArgs(0, 0, 0, 0, new MouseEventArgs( MouseButtons.Left, 1, 0,0,0)));
        }

        private void GridGrades_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Student student = _userService.GetSpecificUserType<Student>(_userService.SignedInUser);

            var selectedRow = GridGrades.Rows[e.RowIndex];
            var selectedCell = selectedRow.Cells[0];
            var selectedSubjectObject = selectedCell.Value;
            var selectedSubjectEnum = (SchoolSubjects)selectedSubjectObject;

            LblGradeInfoSubjectName.Text = selectedSubjectEnum.ToString();

            GridGradeInfo.Rows.Clear();

            IEnumerable<Grade> selectedSubjectGrades = student.Grades.Where(g => g.SchoolSubject == selectedSubjectEnum);

            foreach (var grade in selectedSubjectGrades)
            {
                GridGradeInfo.Rows.Add(grade.Value, grade.Weight, grade.Task, grade.Comment);
            }

        }
    }
}