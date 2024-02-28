using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class DataCatalog_Import
    {
        [JsonProperty("path")]
        public string? Path { get; set; }

        [JsonProperty("schemaContent")]
        public string? SchemaContent { get; set; }
    }
}
