using SchoolManager.Data.Enums;
using SchoolManager.Data.Models;
using SchoolManager.Logic.Services.Grades;
using SchoolManager.Logic.Services.Students;
using SchoolManager.Logic.Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SchoolManager.Desktop.Forms
{
    public partial class FrmMainStudent : Form
    {
        private readonly IUserService _userService = new UserService();
        private readonly IStudentService _studentService = new StudentService();
        private readonly IGradeService _gradeService = new GradeService();

        public FrmMainStudent(IUserService userService)
        {
            _userService = userService;

            InitializeComponent();

            Initialize();
        }



        private void Initialize()
        {
            Student student = _studentService.GetStudentByUser(_userService.SignedInUser);

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
            Student student = _studentService.GetStudentByUser(_userService.SignedInUser);

            var selectedRow = GridGrades.Rows[e.RowIndex];
            var selectedCell = selectedRow.Cells[0];
            var selectedSubjectObject = selectedCell.Value;
            var selectedSubjectEnum = (SchoolSubjects)selectedSubjectObject;

            TxtGradesInfoSubjectName.Text = selectedSubjectEnum.ToString();

            GridGradeInfo.Rows.Clear();

            IEnumerable<Grade> selectedSubjectGrades = student.Grades.Where(g => g.SchoolSubject == selectedSubjectEnum);

            foreach (var grade in selectedSubjectGrades)
            {
                GridGradeInfo.Rows.Add(grade.Value, grade.Weight, grade.Task, grade.Comment);
            }

        }
    }
}