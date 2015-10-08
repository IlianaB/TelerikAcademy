namespace JSON_Processing
{
    using Newtonsoft.Json;

    public class Author
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
