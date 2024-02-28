using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class RowModel
    {
        [JsonProperty("note")]
        public string? Note { get; set; }

        [JsonProperty("conditions")]
        public List<ConditionModel>? Conditions { get; set; }

        [JsonProperty("actions")]
        public List<ActionModel>? Actions { get; set; }
    }
}
