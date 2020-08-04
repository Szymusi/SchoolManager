using SchoolManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Data.Repositories.Messages
{
    class MockMessageRepository : IMessageRepository
    {
        private readonly List<Message> _messages = MockContext.Messages;

        public IEnumerable<Message> GetMessages()
        {
            return _messages;
        }
    }
}
