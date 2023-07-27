using Newtonsoft.Json;
using System.Text.Json;

namespace FuzzyAPI.Models
{
    public class FuzzyRequest
    {
        [JsonProperty]
        [JsonRequired]
        public IEnumerable<string> Menu { get; set; }

        [JsonProperty]
        [JsonRequired]
        public string UserInput { get; set; }

        [JsonProperty]
        [JsonRequired]
        public int Score { get; set; }
    }
}