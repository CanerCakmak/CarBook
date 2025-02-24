using CarBook.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.MainPage
{
    public class Testimonial : BaseEntity
    {
        public Testimonial()
        {
            
        }
        public Testimonial(string name, string title, string comment, string imagepath)
        {
            Name = name;
            Title = title;
            Comment = comment;
            ImagePath = imagepath;
        }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImagePath { get; set; }

    }
}
