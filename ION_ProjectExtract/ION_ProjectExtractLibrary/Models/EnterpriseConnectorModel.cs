using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class EnterpriseConnectorModel
    {
        [JsonProperty("runningStatus")]
        public string? RunningStatus { get; set; }

        [JsonProperty("deployedVersion")]
        public string? DeployedVersion { get; set; }

        [JsonProperty("latestVersion")]
        public string? LatestVersion { get; set; }

        [JsonProperty("host")]
        public string? Host { get; set; }
    }
}
