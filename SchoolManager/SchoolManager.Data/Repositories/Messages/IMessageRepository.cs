using SchoolManager.Data.Models;
using System.Collections.Generic;

namespace SchoolManager.Data.Repositories.Messages
{
    public interface IMessageRepository
    {
        IEnumerable<Message> GetMessages();
    }
}
