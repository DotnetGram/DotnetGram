
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Generate 
{
    public sealed class ApiTypesContainer
    {
        [JsonPropertyName("methods")]
        public Dictionary<string, MethodInfo> Methods { get; set; }
    }
}