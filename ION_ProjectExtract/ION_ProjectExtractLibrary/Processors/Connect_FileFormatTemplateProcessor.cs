using ION_ProjectExtractLibrary.Models;
using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Processors
{
    public class Connect_FileFormatTemplateProcessor
    {
        public static async Task<List<Connect_FileFormatTemplatesModel>> GetInfo()
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                "https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/connect/model/v1/fileformattemplates");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Connect_FileFormatTemplatesModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            {
                return new List<Connect_FileFormatTemplatesModel>();
            }
        }

        public static async Task<List<Connect_FileFormatTemplatesModel>> GetInfo(string name)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"$https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/connect/model/v1/fileformattemplates?name={name}");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Connect_FileFormatTemplatesModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            {
                return new List<Connect_FileFormatTemplatesModel>();
            }
        }

        public static async Task<string> GetJson(string name)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/connect/model/v1/fileformattemplates/{name}");
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
