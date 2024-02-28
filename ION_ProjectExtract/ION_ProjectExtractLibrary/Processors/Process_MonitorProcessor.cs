using ION_ProjectExtractLibrary.Models;
using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Processors
{
    public class Process_MonitorProcessor
    {
        public static async Task<List<Process_MonitorModel>> GetInfo()
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                "https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/process/model/v1/monitors");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Process_MonitorModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            {
                return new List<Process_MonitorModel>();
            }
        }

        public static async Task<List<Process_MonitorModel>> GetInfo(string name)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/process/model/v1/monitors?name={name}");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Process_MonitorModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            {
                return new List<Process_MonitorModel>();
            }
        }

        public static async Task<string> GetJson(string name)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/process/model/v1/monitors/{name}");
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
