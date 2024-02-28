using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class Connect_DataflowModel
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("lastUpdatedBy")]
        public string? LastUpdatedBy { get; set; }

        [JsonProperty("lastUpdatedOn")]
        public DateTime LastUpdatedOn { get; set; }
    }
}
