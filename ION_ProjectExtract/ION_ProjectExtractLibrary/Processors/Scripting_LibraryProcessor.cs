using ION_ProjectExtractLibrary.Models;
using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Processors
{
    public class Scripting_LibraryProcessor
    {
        public static async Task<List<Scripting_LibraryModel>> GetInfo()
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                "https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/scriptingservice/model/v1/scripts");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Scripting_LibraryModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            {
                return new List<Scripting_LibraryModel>();
            }
        }

        public static async Task<List<Scripting_LibraryModel>> GetInfo(string name)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/scriptingservice/model/v1/scripts?name={name}");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Scripting_LibraryModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            {
                return new List<Scripting_LibraryModel>();
            }
        }

        public static async Task<string> GetJson(string name)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/scriptingservice/model/v1/scripts/{name}");
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
