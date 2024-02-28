using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    public class Process_WorkflowsModel
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("lastUpdatedBy")]
        public string? LastUpdatedBy { get; set; }

        [JsonProperty("lastUpdatedOn")]
        public DateTime LastUpdatedOn { get; set; }

        [JsonProperty("tenant")]
        public string? Tenant { get; set; }

        [JsonProperty("activationDate")]
        public DateTime ActivationDate { get; set; }

        [JsonProperty("deactivationDate")]
        public DateTime DeactivationDate { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("changedSinceLastActivation")]
        public bool ChangedSinceLastActivation { get; set; }

        [JsonProperty("variables")]
        public List<VariableModel>? Variables { get; set; }

        [JsonProperty("trees")]
        public List<TreeModel>? Trees { get; set; }
    }
}
