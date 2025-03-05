using CarBook.WebUI.DTOs.AuthorDtos;

namespace CarBook.WebUI.DTOs.BlogDtos
{
    public class BlogWithAuthorResponse
    {
        public string Title { get; set; }
        public string CoverImagePath { get; set; }
        public DateTime CreatedAt { get; set; }

        public AuthorDto Author { get; set; }
    }
}
