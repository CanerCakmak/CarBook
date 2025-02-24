using CarBook.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.MainPage
{
    public class Banner : BaseEntity
    {
        public Banner()
        {

        }
        public Banner(string title, string description, string videoDescription, string videoUrl)
        {
            Title = title;
            Description = description;
            VideoDescription = videoDescription;
            VideoUrl = videoUrl;
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public string VideoDescription { get; set; }
        public string VideoUrl { get; set; }

    }
}
