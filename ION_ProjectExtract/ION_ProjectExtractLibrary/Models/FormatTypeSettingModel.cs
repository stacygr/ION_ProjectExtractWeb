using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class FormatTypeSettingModel
    {
        [JsonProperty("sequenceNumber")]
        public string? fillCharacter { get; set; }

        [JsonProperty("bodnoun")]
        public string? Bodnoun { get; set; }

        [JsonProperty("fieldSeparator")]
        public string? FieldSeparator { get; set; }

        [JsonProperty("lineSeparator")]
        public string? LineSeparator { get; set; }

        [JsonProperty("fieldStart")]
        public string? FieldStart { get; set; }

        [JsonProperty("fieldEnd")]
        public string? FieldEnd { get; set; }

        [JsonProperty("multiplicityGeneratedBod")]
        public string? MultiplicityGeneratedBod { get; set; }

        [JsonProperty("formatType")]
        public string? FormatType { get; set; }

        [JsonProperty("sampleXml")]
        public string? SampleXml { get; set; }

        [JsonProperty("optionalValueIndicator")]
        public string? OptionalValueIndicator { get; set; }

        [JsonProperty("dataFieldSettings")]
        public List<DataFieldSettingModel>? DataFieldSettings { get; set; }
    }
}
