using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class ConditionModel
    {
        [JsonProperty("variable")]
        public string? Variable { get; set; }
    }
}
