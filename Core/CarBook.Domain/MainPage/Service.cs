using CarBook.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.MainPage
{
    public class Service : BaseEntity
    {
        public Service()
        {
            
        }
        public Service(string title, string description,string iconpath)
        {
            Title = title;
            Description = description;
            IconPath = iconpath;
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconPath { get; set; }
    }
}
