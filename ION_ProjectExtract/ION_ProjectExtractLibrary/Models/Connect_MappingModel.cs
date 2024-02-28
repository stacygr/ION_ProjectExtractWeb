using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class Connect_MappingModel
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("lastUpdatedBy")]
        public string? LastUpdatedBy { get; set; }

        [JsonProperty("lastUpdatedOn")]
        public DateTime LastUpdatedOn { get; set; }

        [JsonProperty("stripNamespace")]
        public bool StripNamespace { get; set; }

        [JsonProperty("usageMode")]
        public string? UsageMode { get; set; }

        [JsonProperty("lastApprovedVersion")]
        public int LastApprovedVersion { get; set; }

        [JsonProperty("versions")]
        public List<int>? Versions { get; set; }

        [JsonProperty("mappingType")]
        public string? MappingType { get; set; }

        [JsonProperty("protectOnExport")]
        public bool ProtectOnExport { get; set; }

        [JsonProperty("protected")]
        public bool Protected { get; set; }

        [JsonProperty("majorVersion")]
        public int MajorVersion { get; set; }

        [JsonProperty("sourceDocument")]
        public string? SourceDocument { get; set; }

        [JsonProperty("targetDocument")]
        public string? TargetDocument { get; set; }
    }
}
