using SchoolManager.Data.Models;
using SchoolManager.Data.Models.UserTypes;
using SchoolManager.Data.Repositories.Classes;
using SchoolManager.Data.Repositories.Parents;
using SchoolManager.Data.Repositories.Students;
using SchoolManager.Data.Repositories.Teachers;
using SchoolManager.Data.Repositories.Users;
using SchoolManager.Desktop.Services.ComboBoxHelper;
using SchoolManager.Desktop.Services.GradesTab;
using SchoolManager.Logic.Services.Grades;
using SchoolManager.Logic.Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SchoolManager.Desktop.Forms
{
    public partial class FrmMainTeacher : Form
    {
        private readonly IUserService _userService;
        private readonly IUserRepository _userRepository;
        private readonly IParentRepository _parentRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly IClassRepository _classRepository;
        private readonly IGradeService _gradeService;
        private readonly IComboBoxHelperService _comboBoxHelperService;
        private readonly IGradesTabService _gradesTabService;

        public FrmMainTeacher(
            IGradeService gradeService, 
            IComboBoxHelperService comboBoxHelperService, 
            IUserService userService, 
            IUserRepository userRepository, 
            IParentRepository parentRepository, 
            ITeacherRepository teacherRepository, 
            IStudentRepository studentRepository, 
            IClassRepository classRepository,
            IGradesTabService gradesTabService)
        {
            _comboBoxHelperService = comboBoxHelperService;
            _userService = userService;
            _userRepository = userRepository;
            _parentRepository = parentRepository;
            _teacherRepository = teacherRepository;
            _studentRepository = studentRepository;
            _classRepository = classRepository;
            _gradesTabService = gradesTabService;

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

        private void CmbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Teacher teacher = _userService.GetSpecificUserType<Teacher>(_userService.SignedInUser);
            IEnumerable<Student> students = _studentRepository.GetStudents();

            Student selectedStudent = _comboBoxHelperService.GetSelectedElement(CmbStudents, students, s => $"{s.User.Name} {s.User.Surname}");
            IEnumerable<Grade> selectedStudentGrades = selectedStudent.Grades.Where(g => g.SchoolSubject == teacher.Profesion);

            _gradesTabService.FillGradeTxtBoxInfo(GridGradeInfo, selectedStudentGrades);

        }

        private void GridGradeInfo_SelectionChanged(object sender, EventArgs e)
        {
            if (GridGradeInfo.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedRow = GridGradeInfo.SelectedRows[0];
            int selectedGradeId = Convert.ToInt32(selectedRow.Cells[0].Value);
            IEnumerable<Student> students = _studentRepository.GetStudents();
            Student selectedStudent = _comboBoxHelperService.GetSelectedElement(CmbStudents, students, s => $"{s.User.Name} {s.User.Surname}");
            IEnumerable<Grade> selectedStudentGrades = selectedStudent.Grades;
            Grade selectedGrade = selectedStudentGrades.Single(g => g.Id == selectedGradeId);

            _gradesTabService.FillTxtGradeInfo(selectedGrade, TxtValue, TxtWeight, TxtTask, TxtComment);
            RadEdit.Checked = true;
        }

        private void RadAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (RadAdd.Checked == false)
            {
                return;
            }

            TxtValue.Text = null;
            TxtWeight.Text = null;
            TxtTask.Text = null;
            TxtComment.Text = null;

            GridGradeInfo.ClearSelection();
        }

        private void RadDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (RadAdd.Checked == false)
            {
                return;
            }

            var selectedRow = GridGradeInfo.SelectedRows[0];
            int selectedGradeId = Convert.ToInt32(selectedRow.Cells[0].Value);
            IEnumerable<Student> students = _studentRepository.GetStudents();
            Student selectedStudent = _comboBoxHelperService.GetSelectedElement(CmbStudents, students, s => $"{s.User.Name} {s.User.Surname}");
            IEnumerable<Grade> selectedStudentGrades = selectedStudent.Grades;
            Grade selectedGrade = selectedStudentGrades.Single(g => g.Id == selectedGradeId);

            _gradesTabService.FillTxtGradeInfo(selectedGrade, TxtValue, TxtWeight, TxtTask, TxtComment);
        }

        private void BtnOperation_Click(object sender, EventArgs e)
        {
            var selectedRow = GridGradeInfo.SelectedRows[0];
            int selectedGradeId = Convert.ToInt32(selectedRow.Cells[0].Value);

            IEnumerable<Student> students = _studentRepository.GetStudents();
            Student selectedStudent = _comboBoxHelperService.GetSelectedElement(CmbStudents, students, s => $"{s.User.Name} {s.User.Surname}");
            List<Grade> selectedStudentAllGrades = selectedStudent.Grades;
            Teacher teacher = _userService.GetSpecificUserType<Teacher>(_userService.SignedInUser);
            List<Grade> selectedStudentSubjectGrades = selectedStudent.Grades.Where(g => g.SchoolSubject == teacher.Profesion).ToList();
            Grade selectedGrade = selectedStudentAllGrades.Single(g => g.Id == selectedGradeId);

            if (RadAdd.Checked == true)
            {
                Grade grade = new Grade();

                int gradeId = selectedStudentAllGrades.Last<Grade>().Id + 1;
                var gradeSubject = teacher.Profesion;
                double gradeValue = Convert.ToDouble(TxtValue.Text);
                int gradeWeight = Convert.ToInt32(TxtWeight.Text);
                string gradeTask = TxtTask.Text.ToString();
                string gradeComment = TxtComment.Text.ToString();

                grade.Id = gradeId;
                grade.SchoolSubject = gradeSubject;
                grade.Value = gradeValue;
                grade.Weight = gradeWeight;
                grade.Task = gradeTask;
                grade.Comment = gradeComment;

                selectedStudentSubjectGrades.Add(grade);

                _gradesTabService.FillGradeTxtBoxInfo(GridGradeInfo, selectedStudentSubjectGrades);
            }

            if (RadDelete.Checked == true)
            {
                selectedStudentAllGrades.Remove(selectedGrade);

                _gradesTabService.FillGradeTxtBoxInfo(GridGradeInfo, selectedStudentSubjectGrades);
            }

            if(RadEdit.Checked == true)
            {
                Grade grade = new Grade();

                int gradeId = selectedGrade.Id;
                var gradeSubject = teacher.Profesion;
                double gradeValue = Convert.ToDouble(TxtValue.Text);
                int gradeWeight = Convert.ToInt32(TxtWeight.Text);
                string gradeTask = TxtTask.Text.ToString();
                string gradeComment = TxtComment.Text.ToString();

                grade.Id = gradeId;
                grade.SchoolSubject = gradeSubject;
                grade.Value = gradeValue;
                grade.Weight = gradeWeight;
                grade.Task = gradeTask;
                grade.Comment = gradeComment;

                selectedStudentAllGrades.Remove(selectedGrade);
                selectedStudentAllGrades.Add(grade);

                _gradesTabService.FillGradeTxtBoxInfo(GridGradeInfo, selectedStudentSubjectGrades);
            }
        }
    }
}
