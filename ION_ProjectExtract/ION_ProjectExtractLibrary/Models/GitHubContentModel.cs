using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class GitHubContentModel
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("path")]
        public string? Path { get; set; }

        [JsonProperty("sha")]
        public string? Sha { get; set; }

        [JsonProperty("size")]
        public int? Size { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        [JsonProperty("git_url")]
        public string? GitUrl { get; set; }

        [JsonProperty("download_url")]
        public string? DownloadUrl { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("_links")]
        public GitHubLinkModel? Links { get; set; }
    }
}
