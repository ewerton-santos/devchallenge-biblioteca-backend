using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DevChallenge.Data.Dto
{
    public class BookDto
    {
        [JsonPropertyName("id")]
        public int BookId { get; set; }
        [JsonPropertyName("titulo")]
        public string Title { get; set; }
        [JsonPropertyName("editora")]
        public string PublishingCompany { get; set; }
        [JsonPropertyName("foto")]
        public string ImagePath { get; set; }
        [JsonPropertyName("autores")]
        public List<string> Authors { get; set; }
    }
}
