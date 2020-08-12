using System.Collections.Generic;

namespace SchoolManager.Data.Models
{
    public class Message
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public User Sender { get; set; }

        public List<User> Receivers { get; set; }

        public string Content { get; set; }

        public bool Deleted { get; set; }
    }
}
