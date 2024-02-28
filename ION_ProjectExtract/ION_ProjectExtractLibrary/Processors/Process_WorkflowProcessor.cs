using ION_ProjectExtractLibrary.Models;
using Newtonsoft.Json;

namespace ION_ProjectExtractLibrary.Processors
{
    public class Process_WorkflowProcessor
    {
        public static async Task<List<Process_WorkflowsModel>> GetInfo()
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                "https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/process/model/v1/workflows");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Process_WorkflowsModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            {
                return new List<Process_WorkflowsModel>();
            }
        }

        public static async Task<List<Process_WorkflowsModel>> GetInfo(string name)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/process/model/v1/workflows?name={name}");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Process_WorkflowsModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            {
                return new List<Process_WorkflowsModel>();
            }
        }

        public static async Task<string> GetJson(string name)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/process/model/v1/workflows/{name}");
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
