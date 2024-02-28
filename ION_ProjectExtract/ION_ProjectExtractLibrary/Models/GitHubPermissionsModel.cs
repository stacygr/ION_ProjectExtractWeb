using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class GitHubPermissionsModel
    {
        [JsonProperty("admin")]
        public bool? Admin { get; set; }

        [JsonProperty("maintain")]
        public bool? Maintain { get; set; }

        [JsonProperty("push")]
        public bool? Push { get; set; }

        [JsonProperty("triage")]
        public bool? Triage { get; set; }

        [JsonProperty("pull")]
        public bool? Pull { get; set; }
    }
}
