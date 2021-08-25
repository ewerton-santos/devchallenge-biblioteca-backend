using System.Collections.Generic;

namespace DevChallenge.Data.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string PublishingCompany { get; set; }
        public string ImagePath { get; set; }
        public List<string> Authors { get; set; }
    }
}