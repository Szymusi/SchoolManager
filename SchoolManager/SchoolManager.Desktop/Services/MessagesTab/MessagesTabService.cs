using System.Collections.Generic;
using System.Windows.Forms;

namespace SchoolManager.Desktop.Services.MessagesTab
{
    public class MessagesTabService : IMessagesTabService
    {
        public void FillGridMessageList(DataGridView grid, IEnumerable<Data.Models.Message> messages)
        {
            grid.Rows.Clear();

            foreach (var message in messages)
            {
                string name = $"{message.Sender.Name} {message.Sender.Surname}";
                grid.Rows.Add(message.Id, name, message.Title);
            }
        }
    }
}
