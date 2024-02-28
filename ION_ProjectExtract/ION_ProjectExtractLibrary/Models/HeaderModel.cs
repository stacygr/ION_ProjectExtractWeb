using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class HeaderModel
    {
        [JsonProperty("actionHeaders")]
        public List<ActionHeaderModel>? ActionHeaders { get; set; }

        [JsonProperty("variableHeaders")]
        public List<VariableHeaderModel>? VariableHeaders { get; set; }
    }
}
