using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class DataCatalog_ObjectSchemaModel
    {
        [JsonProperty("objects")]
        public List<DataCatalog_ObjectModel>? Objects { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
