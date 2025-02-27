using CarBook.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.MainPage
{
    public class About : BaseEntity
    {

        public About()
        {
            
        }
        public About(string title, string description, string imagepath)
        {
            Title = title;
            Description = description;
            ImagePath=imagepath;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }



    }
}
