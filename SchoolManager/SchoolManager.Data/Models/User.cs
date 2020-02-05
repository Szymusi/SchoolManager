﻿using SchoolManager.Data.Enums;

namespace SchoolManager.Data.Models
{
    public class User
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public AccountTypes AccountType { get; set; }
    }
}