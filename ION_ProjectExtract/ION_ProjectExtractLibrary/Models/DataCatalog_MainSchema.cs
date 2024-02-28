using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class DataCatalog_MainSchema
    {
        [JsonProperty("path")]
        public string? Path { get; set; }

        [JsonProperty("schemaContent")]
        public string? SchemaContent { get; set; }
    }
}
