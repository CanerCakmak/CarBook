using CarBook.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class Blog : BaseEntity
    {
        public Blog()
        {
            
        }
        public Blog(string Title, string CoverImagePath, int AuthorId)
        {
            this.Title = Title;
            this.CoverImagePath = CoverImagePath;
            this.AuthorId = AuthorId;
        }
        public string Title { get; set; }
        public string CoverImagePath { get; set; }


        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public ICollection<BlogCategory> BlogCategories { get; set; }
    }
}
