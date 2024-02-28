using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class GitHubCreateOrUpdateFileResponseModel
    {
        [JsonProperty("content")]
        public GitHubContentModel Content { get; set; }
    }
}
