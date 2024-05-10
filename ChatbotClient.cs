using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SeniorPro
{
    public class ChatbotClient
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl;
        private readonly string secretKey;

        public ChatbotClient(string apiUrl, string secretKey)
        {
            this.apiUrl = apiUrl;
            this.secretKey = secretKey;
            this.httpClient = new HttpClient();
        }

        public async Task<string> TrimiteIntrebare(string intrebare)
        {
            var requestUri = $"{apiUrl}?intrebare={Uri.EscapeDataString(intrebare)}";
            var response = await httpClient.GetAsync(requestUri);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return "Eroare la obținerea răspunsului de la chatbot.";
            }
        }
    }
}
