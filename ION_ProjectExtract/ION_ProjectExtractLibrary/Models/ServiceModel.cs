using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class ServiceModel
    {
        [JsonProperty("serviceName")]
        public string? ServiceName { get; set; }

        [JsonProperty("runningStatus")]
        public string? RunningStatus { get; set; }

        [JsonProperty("deployedVersion")]
        public string? DeployedVersion { get; set; }

        [JsonProperty("latestVersion")]
        public string? LatestVersion { get; set; }
    }
}
