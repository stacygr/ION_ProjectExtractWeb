using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class Connect_EnterpriseLocationsModel
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("version")]
        public string? Version { get; set; }

        [JsonProperty("host")]
        public string? Host { get; set; }

        [JsonProperty("enterpriseConnector")]
        public EnterpriseConnectorModel? EnterpriseConnector { get; set; }

        [JsonProperty("services")]
        public List<ServiceModel>? Services { get; set; }
    }
}
