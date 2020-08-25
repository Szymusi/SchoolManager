using System.Collections.Generic;
using System.Windows.Forms;
namespace SchoolManager.Desktop.Services.MessagesTab
{
    public interface IMessagesTabService
    {
        void FillGridMessageList(DataGridView grid, IEnumerable<Data.Models.Message> messages);
    }
}
