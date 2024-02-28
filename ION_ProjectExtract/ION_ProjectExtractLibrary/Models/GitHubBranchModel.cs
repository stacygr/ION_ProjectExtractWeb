using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class GitHubBranchModel
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("commit")]
        public GitHubCommitModel? Commit { get; set; }

        [JsonProperty("protected")]
        public bool? Protected { get; set; }
    }
}
