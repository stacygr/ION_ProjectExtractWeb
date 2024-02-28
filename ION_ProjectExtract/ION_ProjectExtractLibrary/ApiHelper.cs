using System.Net.Http.Headers;

namespace ION_ProjectExtractLibrary
{
    public class ApiHelper
    {
        public static HttpClient? ApiClient { get; private set; }

        public static async Task InitializeClientAsync()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            ApiClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", await IonAuthenticate.GetTokenAsync());
            ApiClient.DefaultRequestHeaders.Add("Accept", "*/*");
            ApiClient.DefaultRequestHeaders.Add("User-Agent", "ION Github");
            ApiClient.DefaultRequestHeaders.Add("Accept-Encoding", "Accept-Encoding");
            ApiClient.DefaultRequestHeaders.Add("Connection", "keep-alive");
        }
    }
}
