using ION_ProjectExtractLibrary.Models;
using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Processors
{
    public class Connect_EnterpriseLocationProcessor
    {
        public static async Task<List<Connect_EnterpriseLocationsModel>> GetInfo()
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                "https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/connect/model/v1/enterpriselocations");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Connect_EnterpriseLocationsModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            { 
                return new List<Connect_EnterpriseLocationsModel>();
            }
        }

        public static async Task<List<Connect_EnterpriseLocationsModel>> GetInfo(string name)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/connect/model/v1/enterpriselocations?name={name}");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Connect_EnterpriseLocationsModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            { 
                return new List<Connect_EnterpriseLocationsModel>();
            }
        }

        public static async Task<string> GetJson(string name)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/connect/model/v1/enterpriselocations/{name}");
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}

