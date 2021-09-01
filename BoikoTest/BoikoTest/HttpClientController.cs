using System.Net.Http;

namespace TestBoiko
{
    internal class HttpClientController
    {
        private static HttpClientController _httpClientController;

        private HttpClientController()
        {
            HttpClient = new HttpClient();
        }

        public static HttpClientController Instance => _httpClientController ??= new HttpClientController();

        public readonly HttpClient HttpClient;
    }
}
