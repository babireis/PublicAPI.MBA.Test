using Newtonsoft.Json;

namespace PublicAPI.MBA.Test.Infraestrutura.Models
{
    public class CalculoIdadeResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

    }
}
