using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace B24Api.Crm
{
    public class B24ApiGetway
    {
        private const int HTTP_CLIENT_TIMEOUT = 60;

        private string? url = null;

        private HttpClient? httpClient = null;
        private HttpClient HttpClient
        {
            get
            {
                if (httpClient == null)
                {
                    HttpClientHandler httpClientHandler = new()
                    {
                        ClientCertificateOptions = ClientCertificateOption.Manual,
                        ServerCertificateCustomValidationCallback
                            = (httpRequestMessage, cert, certChain, sslPlicyError) => true
                    };

                    httpClient = new HttpClient(httpClientHandler)
                    {
                        BaseAddress = new Uri(url ?? ""),
                        Timeout = TimeSpan.FromSeconds(HTTP_CLIENT_TIMEOUT)
                    };
                }

                return httpClient;
            }
        }

        public B24ApiGetway(string webHook) 
        {
            this.url = webHook;
        }

        public async Task<string> RunAction(string action, IDictionary<string, object>? data = null)
        {
            HttpContent? content = null;
            if (data != null)
            {
                content = new StringContent(
                    JsonSerializer.Serialize(data),
                    Encoding.UTF8,
                    "application/json"
                );
            }
            var response = await HttpClient.PostAsync(this.url + action, content);

            return await response.Content.ReadAsStringAsync();
        }
    }
}
