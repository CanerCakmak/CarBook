﻿using CarBook.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.MainPage
{
    public class Contact : BaseEntity
    {
        public Contact()
        {
            
        }
        public Contact(string name , string email, string subject,string message)
        {
            Name = name;
            Email = email;
            Subject = subject;
            Message = message;
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }



    }
}
