using ION_ProjectExtractLibrary.Models;
using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Processors
{
    public class Connect_DataFlowProcesser
    {
        public static async Task<List<Connect_DataflowModel>> GetInfo()
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                "https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/connect/model/v1/dataflows");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Connect_DataflowModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            {
                return new List<Connect_DataflowModel>();
            }
        }

        public static async Task<List<Connect_DataflowModel>> GetInfo(string name)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/connect/model/v1/dataflows?name={name}");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Connect_DataflowModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            { 
                return new List<Connect_DataflowModel>();
            }
        }

        public static async Task<string> GetJson(string name)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/connect/model/v1/dataflows/{name}");
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
