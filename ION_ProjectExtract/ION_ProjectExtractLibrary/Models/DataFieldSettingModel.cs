using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class DataFieldSettingModel
    {
        [JsonProperty("sequenceNumber")]
        public int SequenceNumber { get; set; }

        [JsonProperty("fieldName")]
        public string? FieldName { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("optionalField")]
        public bool OptionalField { get; set; }
    }
}
