using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Models
{
    internal class OauthBodyModel
    {
        [JsonProperty("grant_type")]
        public string? GrantType { get; set; }

        [JsonProperty("username")]
        public string? UserName { get; set; }

        [JsonProperty("password")]
        public string? Password { get; set; }

        [JsonProperty("client_id")]
        public string? ClientId { get; set; }

        [JsonProperty("client_secret")]
        public string? ClientSecret { get; set; }
    }
}
