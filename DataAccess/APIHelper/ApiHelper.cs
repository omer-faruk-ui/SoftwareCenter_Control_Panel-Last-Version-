
using System.Net.Http.Headers;

namespace DataAccess.ApiHelper
{
    public class ApiHelper
    {
        public static HttpClient ApiClient { get; set; } = null!;

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
