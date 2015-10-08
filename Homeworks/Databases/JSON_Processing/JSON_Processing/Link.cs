namespace JSON_Processing
{
    using Newtonsoft.Json;

    public class Link
    {
        [JsonProperty("@href")]
        public string Href { get; set; }
    }
}
