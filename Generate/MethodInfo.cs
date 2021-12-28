
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel;
using System.Collections;


namespace Generate 
{
    public sealed class MethodInfo
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("href")]
        public string Href { get; set; }
        [JsonPropertyName("returns")]
        public string[] Returns { get; set; }
        [JsonPropertyName("description")]
        public string[] Description { get; set; }
    }
}