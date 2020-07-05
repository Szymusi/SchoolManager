using SchoolManager.Data.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SchoolManager.Desktop.Services.GradesTab
{
    public interface IGradesTabService
    {
        void FillGradeTxtBoxInfo(DataGridView grid, IEnumerable<Grade> grades);
        void FillTxtGradeInfo(Grade grade, TextBox txtValue, TextBox txtWeight, TextBox txtTask, TextBox txtComment);

    }
}
