using Newtonsoft.Json;
using Azure.Security.KeyVault.Secrets;
using Azure.Identity;

namespace ION_ProjectExtractLibrary
{
    public class AzureKeyvault
    {
        public string? Ti { get; set; }
        public string? Ci { get; set; }
        public string? Cs { get; set; }
        public string? Pu { get; set; }
        public string? Ot { get; set; }
        public string? Saak { get; set; }
        public string? Sask { get; set; }

        public static AzureKeyvault GetSecret()
        {
            var client = new SecretClient(new Uri("https://key-jbt-integration-dev.vault.azure.net/"),
                new ClientSecretCredential(tenantId: "55d6bf49-bce4-4a16-b381-213fbace1fad",
                                           clientId: "80105f42-eff2-4299-b30b-4ad212830c87",
                                           clientSecret: "p4x8Q~0wM3o8dEKF3zKDQCM42IDcNMSt~ltbXaHQ"));

            var Secret = client.GetSecret("ION-DevOps-Pipeline");
            var ionDevOpsPipelineSecret = Secret.Value.Value.ToString();
            var result = JsonConvert.DeserializeObject<AzureKeyvault>(ionDevOpsPipelineSecret);

            if (result != null)
            {
                return result;
            }
            else
            {
                return new AzureKeyvault();
            }
        }
    }
}
