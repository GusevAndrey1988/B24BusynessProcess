using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace B24Api
{
    public class Crm
    {
        private readonly HttpClient client;

        private string _webHook = "";
        public string WebHook
        {
            get
            {
                return _webHook;
            }
            set
            {
                _webHook = value;
                client.BaseAddress= new Uri(_webHook);
            }
        }

        public Crm()
        {
            client = new HttpClient(CreateHttpClientHandler());
        }

        private static HttpClientHandler CreateHttpClientHandler()
        {
            var requestHandler = new HttpClientHandler
            {
                ClientCertificateOptions = ClientCertificateOption.Manual,
                ServerCertificateCustomValidationCallback =
                    (httpRequestMessage, cert, certChain, plicyError) => true
            };

            return requestHandler;
        }

        public async Task<List<Deal>?> DealList()
        {
            return await Task.Run(async () =>
            {
                var responseMessage = await client.GetAsync("crm.deal.list");
                var body = await responseMessage.Content.ReadAsStreamAsync();

                var result = (await JsonSerializer.DeserializeAsync<DealListResponse>(body));
                return result?.result ?? new List<Deal>();
            });
        }
    }
}
