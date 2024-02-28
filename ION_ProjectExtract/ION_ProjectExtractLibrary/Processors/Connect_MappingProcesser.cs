using ION_ProjectExtractLibrary.Models;
using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Processors
{
    public class Connect_MappingProcesser
    {
        public static async Task<List<Connect_MappingModel>> GetInfo()
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                "https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/connect/model/v1/mappings/");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Connect_MappingModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            { 
                return new List<Connect_MappingModel>(); 
            }    
        }

        public static async Task<List<Connect_MappingModel>> GetInfo(string name)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/connect/model/v1/mappings/?name={name}");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Connect_MappingModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else 
            {
                return new List<Connect_MappingModel>();
            }
        }

        public static async Task<string> GetJson(string name)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/connect/model/v1/mappings/{name}");
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
