using SchoolManager.Data.Enums;
using SchoolManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SchoolManager.Desktop.Services.GradesTab
{
    public class GradesTabService : IGradesTabService
    {
        public void FillGradeTxtBoxInfo(DataGridView grid,  IEnumerable<Grade> grades)
        {
            grid.Rows.Clear();

            foreach (var grade in grades)
            {
                grid.Rows.Add(grade.Id, grade.Value, grade.Weight, grade.Task, grade.Comment);
            }

        }

        public void FillTxtGradeInfo(Grade grade, TextBox txtValue, TextBox txtWeight, TextBox txtTask, TextBox txtComment)
        {
            txtValue.Text = grade.Value.ToString();
            txtWeight.Text = grade.Weight.ToString();
            txtTask.Text = grade.Task;
            txtComment.Text = grade.Comment;
        }

        public Grade SelectedGrade(IEnumerable<Grade> grades, DataGridView dataGrid)
        {
            if (dataGrid.SelectedRows.Count == 0)
            {
                return null;
            }
            var selectedRow = dataGrid.SelectedRows[0];
            int selectedGradeId = Convert.ToInt32(selectedRow.Cells[0].Value);
            Grade selectedGrade = grades.Single(g => g.Id == selectedGradeId);

            return selectedGrade;
        }
    }
}
