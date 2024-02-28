using ION_ProjectExtractLibrary.Models;
using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Processors
{
    public class Process_BusinessRulesProcessor
    {
        public static async Task<List<Process_BusinessRulesModel>> GetInfo()
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                "https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/process/model/v1/businessrules");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Process_BusinessRulesModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            {
                return new List<Process_BusinessRulesModel>();
            }
        }

        public static async Task<List<Process_BusinessRulesModel>> GetInfo(string name)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/process/model/v1/businessrules?name={name}");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Process_BusinessRulesModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            { 
                return new List<Process_BusinessRulesModel>(); 
            }  
        }

        public static async Task<string> GetJson(string name)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/process/model/v1/businessrules/{name}");
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
