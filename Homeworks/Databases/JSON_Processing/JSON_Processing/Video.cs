using System;

namespace JSON_Processing
{
    using Newtonsoft.Json;

    public class Video
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public Link Link { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("published")]
        public DateTime Date { get; set; }
    }
}
