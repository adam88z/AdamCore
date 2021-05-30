﻿using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Data;


namespace AdamCore.Models
{
    public partial class Users
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

    public class IndexViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

}
