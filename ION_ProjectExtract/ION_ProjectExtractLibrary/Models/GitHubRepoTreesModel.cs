using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class GitHubRepoTreesModel
    {
        [JsonProperty("sha")]
        public string? Sha { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("tree")]
        public List<GitHubTreeModel>? Tree { get; set; }

        [JsonProperty("truncated")]
        public bool? Truncated { get; set; }
    }
}
