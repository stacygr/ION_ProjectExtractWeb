using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class GitHubCommitModel
    {
        [JsonProperty("sha")]
        public string? Sha { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }
    }
}
