using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class ParameterModel
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("dataType")]
        public string? DataType { get; set; }

        [JsonProperty("usageType")]
        public string? UsageType { get; set; }

        [JsonProperty("restriction")]
        public RestrictionModel? Restriction { get; set; }
    }
}
