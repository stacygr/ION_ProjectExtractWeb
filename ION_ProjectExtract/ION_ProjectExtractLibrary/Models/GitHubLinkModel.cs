using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class GitHubLinkModel
    {
        [JsonProperty("self")]
        public string? Self { get; set; }

        [JsonProperty("git")]
        public string? Git { get; set; }

        [JsonProperty("html")]
        public string? Html { get; set; }
    }
}
