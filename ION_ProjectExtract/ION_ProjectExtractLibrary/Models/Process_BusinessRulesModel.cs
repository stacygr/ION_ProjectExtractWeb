using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class Process_BusinessRulesModel
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("matrixType")]
        public string? MatrixType { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("updatedBy")]
        public string? UpdatedBy { get; set; }

        [JsonProperty("updatedByIdentifier")]
        public string? UpdatedByIdentifier { get; set; }

        [JsonProperty("lastUpdatedOn")]
        public DateTime LastUpdatedOn { get; set; }

        [JsonProperty("rejectComment")]
        public string? RejectComment { get; set; }

        [JsonProperty("parameters")]
        public List<ParameterModel>? Parameters { get; set; }

        [JsonProperty("header")]
        public HeaderModel? Header { get; set; }

        [JsonProperty("rows")]
        public List<RowModel>? Rows { get; set; }
    }
}
