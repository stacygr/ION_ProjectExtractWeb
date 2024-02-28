using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class Scripting_ScriptModel
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("lastUpdatedOn")]
        public DateTime LastUpdatedOn { get; set; }

        [JsonProperty("lastUpdatedBy")]
        public string? LastUpdatedBy { get; set; }

        [JsonProperty("versions")]
        public List<int>? Versions { get; set; }

        [JsonProperty("lastApprovedVersionNumber")]
        public int LastApprovedVersionNumber { get; set; }
    }
}
