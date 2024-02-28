using ION_ProjectExtractLibrary.Models;
using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Processors
{
    public class Process_AlarmTemplateProcessor
    {
        public static async Task<List<Process_AlarmTemplateModel>> GetInfo()
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                "https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/process/model/v1/alarmtemplates");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Process_AlarmTemplateModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            {
                return new List<Process_AlarmTemplateModel>();
            }
        }

        public static async Task<List<Process_AlarmTemplateModel>> GetInfo(string name)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/process/model/v1/alarmtemplates?name={name}");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Process_AlarmTemplateModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            {
                return new List<Process_AlarmTemplateModel>();
            }
        }

        public static async Task<string> GetJson(string name)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/process/model/v1/alarmtemplates/{name}");
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
