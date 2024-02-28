using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class DataCatalog_Schema
    {
        [JsonProperty("mainSchema")]
        public DataCatalog_MainSchema? MainSchema { get; set; }

        [JsonProperty("imports")]
        public List<DataCatalog_Import>? Imports { get; set; }
    }
}
