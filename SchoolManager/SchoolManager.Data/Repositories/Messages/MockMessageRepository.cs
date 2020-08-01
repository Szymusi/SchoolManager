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
        private readonly List<Message> _messages = new List<Message>
        {
  /*          new Message
            {
                Id = 1,
                Title = "First mail",
                Sender = ,
                Receiver =,
                Content = ,
                Deleted = 
            }*/
        };

        public IEnumerable<Message> GetMessages()
        {
            return _messages;
        }
    }
}
