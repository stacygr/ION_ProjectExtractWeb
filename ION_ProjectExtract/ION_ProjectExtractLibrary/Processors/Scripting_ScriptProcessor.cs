using ION_ProjectExtractLibrary.Models;
using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Processors
{
    public class Scripting_ScriptProcessor
    {
        public static async Task<List<Scripting_ScriptModel>> GetInfo()
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                "https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/scriptingservice/model/v1/libraries");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Scripting_ScriptModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            {
                return new List<Scripting_ScriptModel>();
            }
        }

        public static async Task<List<Scripting_ScriptModel>> GetInfo(string name)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/scriptingservice/model/v1/libraries?name={name}");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Scripting_ScriptModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            {
                return new List<Scripting_ScriptModel>();
            }
        }

        public static async Task<string> GetJson(string name)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/scriptingservice/model/v1/libraries/{name}");
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
