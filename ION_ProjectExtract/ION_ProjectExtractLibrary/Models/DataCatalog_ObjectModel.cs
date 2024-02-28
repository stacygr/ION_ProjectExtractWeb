using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class DataCatalog_ObjectModel
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("subType")]
        public string? SubType { get; set; }

        [JsonProperty("lastUpdatedBy")]
        public string? LastUpdatedBy { get; set; }

        [JsonProperty("lastUpdatedOn")]
        public long LastUpdatedOn { get; set; }
    }
}
