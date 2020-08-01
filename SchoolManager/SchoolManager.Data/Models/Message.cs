namespace SchoolManager.Data.Models
{
    class Message
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public User Sender { get; set; }

        public User Receiver { get; set; }

        public string Content { get; set; }

        public bool Deleted { get; set; }
    }
}
