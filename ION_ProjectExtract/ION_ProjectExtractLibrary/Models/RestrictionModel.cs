using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class RestrictionModel
    {
        [JsonProperty("restrictionType")]
        public string? RestrictionType { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }
    }
}
