using CarBook.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class Author : BaseEntity
    {
        public Author()
        {
            
        }
        public Author(int Name, string ImagePath, string Description)
        {
            this.Name = Name;
            this.ImagePath = ImagePath;
            this.Description = Description;
        }
        public int Name { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }



        public ICollection<Blog> Blogs { get; set; }
    }
}
