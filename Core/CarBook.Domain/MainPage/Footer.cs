using CarBook.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.MainPage
{
    public class Footer : BaseEntity
    {
        public Footer()
        {
               
        }
        public Footer(string detail,string address, string phoneNumber, string email)
        {
            Detail = detail;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public string Detail{ get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }


    }
}
