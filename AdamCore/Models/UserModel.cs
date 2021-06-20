﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdamCore.Models
{
    public class Users
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool ChangePassword { get; set; }
        public int ID { get; set; }
        public string Email { get; set; }
    }
}
