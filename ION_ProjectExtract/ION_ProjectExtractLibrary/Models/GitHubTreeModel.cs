using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ION_ProjectExtractLibrary.Models
{
    public class GitHubTreeModel
    {
        [JsonProperty("path")]
        public string? Path { get; set; }

        [JsonProperty("mode")]
        public string? Mode { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("sha")]
        public string? Sha { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("size")]
        public int? Size { get; set; }
    }
}
