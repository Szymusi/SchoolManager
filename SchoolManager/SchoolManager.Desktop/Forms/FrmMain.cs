using SchoolManager.Data.Enums;
using SchoolManager.Data.Models;
using SchoolManager.Data.Repositories.Students;
using SchoolManager.Data.Repositories.Users;
using SchoolManager.Logic.Services.Grades;
using SchoolManager.Logic.Services.Students;
using SchoolManager.Logic.Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SchoolManager.Desktop.Forms
{
    public partial class FrmMain : Form
    {
        private readonly IUserService _userService = new UserService();
        private readonly IStudentService _studentService = new StudentService();
        private readonly IGradeService _gradeService = new GradeService();

        public FrmMain()
        {
            SignIn();

            InitializeComponent();

            Initialize();
        }

        private void SignIn()
        {
            FrmSignIn frmSignIn = new FrmSignIn();

            DialogResult dialogResult = frmSignIn.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                bool signIn = _userService.SignIn(frmSignIn.Email, frmSignIn.Password);

                if (!signIn)
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void Initialize()
        {
            Student student = _studentService.GetStudentByUser(_userService.SignedInUser);

            string signedInUserInfo = $"Name: {_userService.SignedInUser.Name} {_userService.SignedInUser.Surname}   Role: {_userService.SignedInUser.AccountType} ";
            LblAccountInfo.Text = signedInUserInfo;

            IEnumerable<SchoolSubjects> schoolSubjects = (IEnumerable<SchoolSubjects>)Enum.GetValues(typeof(SchoolSubjects));

            foreach (var subject in schoolSubjects)
            {
                IEnumerable<Grade> subjectGrades = student.Grades.Where(g => g.SchoolSubject == subject);

                double avarage = _gradeService.CalculateAvarage(subjectGrades);

                IEnumerable<double> gradeValues = subjectGrades.Select(g => g.Value);

                string gradesString = string.Join(", ", gradeValues);

                GridGrades.Rows.Add(subject, gradesString, avarage);
            }
        }
    }
}