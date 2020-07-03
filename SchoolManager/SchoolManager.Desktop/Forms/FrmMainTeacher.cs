﻿using Ninject;
using SchoolManager.Data.Models;
using SchoolManager.Data.Models.UserTypes;
using SchoolManager.Data.Repositories.Classes;
using SchoolManager.Data.Repositories.Parents;
using SchoolManager.Data.Repositories.Students;
using SchoolManager.Data.Repositories.Teachers;
using SchoolManager.Data.Repositories.Users;
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
        private readonly IUserRepository _userRepository;
        private readonly IParentRepository _parentRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly IClassRepository _classRepository;
        private readonly IUserService _userService;
        private readonly IComboBoxHelperService _comboBoxHelperService = new ComboBoxHelperService();

        public FrmMainTeacher(IUserService userService, IUserRepository userRepository, IParentRepository parentRepository, ITeacherRepository teacherRepository, IStudentRepository studentRepository, IClassRepository classRepository)
        {
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

            GridGradeInfo.Rows.Clear();

            IEnumerable<Grade> selectedStudentGrades = selectedStudent.Grades.Where(g => g.SchoolSubject == teacher.Profesion);

            foreach (var grade in selectedStudentGrades)
            {
                GridGradeInfo.Rows.Add(grade.Value, grade.Weight, grade.Task, grade.Comment);
            }
            GridGradeInfo.Rows[0].Selected = false;
        }
    }
}
