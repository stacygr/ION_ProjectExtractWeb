using ION_ProjectExtractLibrary.Models;
using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Processors
{
    public class Process_ActivationPolicyProcessor
    {
        public static async Task<List<Process_ActivationPolicyModel>> GetInfo()
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                "https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/process/model/v1/activationpolicies");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Process_ActivationPolicyModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            {
                return new List<Process_ActivationPolicyModel>();
            }
        }

        public static async Task<List<Process_ActivationPolicyModel>> GetInfo(string name)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/process/model/v1/activationpolicies?name={name}");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Process_ActivationPolicyModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            { 
                return new List<Process_ActivationPolicyModel>();
            }
        }

        public static async Task<string> GetJson(string name)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/process/model/v1/activationpolicies/{name}");
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
