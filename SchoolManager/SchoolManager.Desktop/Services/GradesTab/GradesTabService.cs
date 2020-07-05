using SchoolManager.Data.Models;
using System.Collections.Generic;
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
    }
}
