using ION_ProjectExtractLibrary.Models;
using Newtonsoft.Json;
using System.Text;

namespace ION_ProjectExtractLibrary
{
    public class IonAuthenticate
    {
        public static async Task<string> GetTokenAsync()
        {
            var secret = AzureKeyvault.GetSecret();

            string oauthUrl = secret.Pu + secret.Ot;

            string oauthBody = "grant_type=password&username=" + secret.Saak + "&password=" + secret.Sask + "&client_id=" + secret.Ci + "&client_secret=" + secret.Cs;

            var stringContent = new StringContent(oauthBody, Encoding.UTF8, "application/x-www-form-urlencoded");
            TokenModel? result = new();

            using HttpResponseMessage response = await ApiHelper.ApiClient.PostAsync(oauthUrl, stringContent);

            if (response.IsSuccessStatusCode)
            {
                var credentials = await response.Content.ReadAsStringAsync();

                if (credentials != null)
                {
                    result = JsonConvert.DeserializeObject<TokenModel>(credentials);
                }
                else
                {
                    credentials = "";
                }

                if (result != null)
                {
                    if (result.AccessToken != null)
                    {
                        return result.AccessToken;
                    }
                    else
                    {
                        return "";
                    }
                }
                else
                {
                    return "";
                }

            }
            else
            {
                return "error";
            }
        }
    }
}
