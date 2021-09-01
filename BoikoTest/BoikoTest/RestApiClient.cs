using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using TestBoiko.Models;

namespace TestBoiko
{
    class RestApiClient
    {
        #region Singleton

        public static RestApiClient _restApiClient;

        private RestApiClient()
        {
        }

        public static RestApiClient Instance => _restApiClient ??= new RestApiClient();

        #endregion

        public async Task<Shop> Get(string url)
        {
            Shop shop = Shop.Empty;
            try
            {
                var response = await HttpClientController.Instance.HttpClient.GetStringAsync(url);
                shop = JsonConvert.DeserializeObject<Shop>(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Get: {ex}");
            }
            return shop;
        }
    }
}
