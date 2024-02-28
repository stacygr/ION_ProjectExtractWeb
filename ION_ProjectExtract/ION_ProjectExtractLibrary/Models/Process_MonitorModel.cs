using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class Process_MonitorModel
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("tenant")]
        public string? Tenant { get; set; }

        [JsonProperty("workflowName")]
        public string? WorkflowName { get; set; }

        [JsonProperty("author")]
        public string? Author { get; set; }

        [JsonProperty("lastUpdated")]
        public DateTime LastUpdated { get; set; }

        [JsonProperty("activationDate")]
        public DateTime ActivationDate { get; set; }

        [JsonProperty("deactivationDate")]
        public DateTime DeactivationDate { get; set; }

        [JsonProperty("workflowMajorVersion")]
        public int WorkflowMajorVersion { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("changedSinceLastActivation")]
        public bool ChangedSinceLastActivation { get; set; }
    }
}
