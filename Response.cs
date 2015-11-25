using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GenderizeDotNet.Models
{
    public class Response
    {
        private string gender { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Gender Gender { get; set; }

        [JsonProperty("probability")]
        public string Probability { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        None,
    }
}

