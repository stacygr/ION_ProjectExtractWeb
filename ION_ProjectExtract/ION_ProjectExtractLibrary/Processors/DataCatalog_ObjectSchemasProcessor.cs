using ION_ProjectExtractLibrary.Models;
using Newtonsoft.Json;
using System.Linq;

namespace ION_ProjectExtractLibrary.Processors
{
    public class DataCatalog_ObjectSchemasProcessor
    {
        public static async Task<DataCatalog_ObjectSchemaModel> GetInfo()
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                "https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/datacatalog/v1/object/list");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<DataCatalog_ObjectSchemaModel>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            {
                return new DataCatalog_ObjectSchemaModel();
            }
        }

        public static async Task<DataCatalog_ObjectSchemaModel> GetInfo(string name)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/datacatalog/V1/object/list?name={name}");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<DataCatalog_ObjectSchemaModel>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            {
                return new DataCatalog_ObjectSchemaModel();
            }
        }

        public static async Task<string> GetPayload(string name)
        {
            using HttpResponseMessage listResponse = await ApiHelper.ApiClient!.GetAsync(
                "https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/datacatalog/v1/object/list");
            var listResultString = await listResponse.Content.ReadAsStringAsync();
            var listResult = JsonConvert.DeserializeObject<DataCatalog_ObjectSchemaModel>(listResultString);

            if (listResult != null)
            {
                List<DataCatalog_ObjectModel> listResults = new List<DataCatalog_ObjectModel>();
                foreach (var item in listResult.Objects)
                {
                    listResults.Add(item);
                }
                var test = listResults.Where(x => x.Name == name).ToList();

                if (test[0].Type == "BOD")
                {
                    using HttpResponseMessage propertiesResponse = await ApiHelper.ApiClient!.GetAsync(
                        "https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/datacatalog/v1/object/" + test[0].Name + "/properties");
                    var propertiesResultString = await propertiesResponse.Content.ReadAsStringAsync();

                    using HttpResponseMessage schemaResponse = await ApiHelper.ApiClient!.GetAsync(
                        "https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/datacatalog/v1/object/" + test[0].Name + "/schema");
                    var schemaResultString = await schemaResponse.Content.ReadAsStringAsync();
                    var schemaResult = JsonConvert.DeserializeObject<DataCatalog_Schema>(schemaResultString);
                }
                string helloWorld = "HelloWorld";
            }


            using HttpResponseMessage response = await ApiHelper.ApiClient!.GetAsync(
                $"https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/IONSERVICES/connect/model/v1/connectionpoints/{name}");
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
