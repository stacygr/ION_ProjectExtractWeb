using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class Connect_ConnectionPointModel
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("connectorType")]
        public string? ConnectorType { get; set; }

        [JsonProperty("logicalIdType")]
        public string? LogicalIdType { get; set; }

        [JsonProperty("logicalId")]
        public string? LogicalId { get; set; }

        [JsonProperty("lastUpdatedBy")]
        public string? LastUpdatedBy { get; set; }

        [JsonProperty("lastUpdatedOn")]
        public DateTime LastUpdatedOn { get; set; }

        [JsonProperty("cloudAccount")]
        public string? CloudAccount { get; set; }

        [JsonProperty("enterpriseLocation")]
        public string? EnterpriseLocation { get; set; }
    }
}
