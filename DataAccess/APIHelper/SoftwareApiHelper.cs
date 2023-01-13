using APIHelper.Models;
using Newtonsoft.Json;
using System.Reflection;
using System.Resources;

namespace DataAccess.ApiHelper
{
    public  class SoftwareApiHelper : ApiHelper
    {
        private static readonly ResourceManager rs = new("DataAccess.Resources.API_URL", Assembly.GetExecutingAssembly());
        private static string? url;
        static List<Software> softwares = null!;
        public static async Task<List<Software>> GetSoftwares()
        {
            url = rs.GetString("GetSoftwaresURL");
                   
            HttpResponseMessage response = ApiClient.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                softwares = JsonConvert.DeserializeObject<List<Software>>(content)!;
                return softwares;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}
