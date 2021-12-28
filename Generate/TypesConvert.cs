
using System.Text.Json;
using System.ComponentModel;
using System.Collections;

namespace Generate 
{
    public sealed class TypesConvert
    {
        public static object Convert(string input)
        {
            var obj = JsonSerializer.Deserialize<ApiTypesContainer>(input);
            return obj;
        }
    }
}
