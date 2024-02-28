using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class Scripting_LibraryModel
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("lastVersionNumber")]
        public string? LastVersionNumber { get; set; }

        [JsonProperty("lastVersionDescription")]
        public string? LastVersionDescription { get; set; }

        [JsonProperty("lastUpdatedOn")]
        public DateTime LastUpdatedOn { get; set; }

        [JsonProperty("lastUpdatedBy")]
        public string? LastUpdatedBy { get; set; }
    }
}
