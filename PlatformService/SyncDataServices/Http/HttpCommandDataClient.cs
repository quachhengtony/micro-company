using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using PlatformService.Dtos;

namespace PlatformService.SyncDataServices.Http
{
    public class HttpCommandDataClient : ICommandDataClient
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public HttpCommandDataClient(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task SendPlatformToCommand(PlatformReadDto platform)
        {
            try
            {
                var httpContent = new StringContent(
                JsonSerializer.Serialize(platform),
                Encoding.UTF8,
                "application/json"
                );

                // var response = await _httpClient.PostAsync($"{_configuration["CommandService"]}", httpContent);

                // if (response.IsSuccessStatusCode)
                // {
                //     Console.WriteLine("Sync POST to CommandsService success!");
                // }
                // else
                // {
                //     Console.WriteLine("Sync POST to CommandsService failed!");
                // }

                HttpResponseMessage response = await _httpClient.PostAsync($"{_configuration["CommandService"]}", httpContent);

                response.EnsureSuccessStatusCode();
                Console.WriteLine("Sync POST to CommandsService success!");

            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Sync POST to CommandsService failed!");
                Console.WriteLine("Message :{0} ", ex.Message);
            }
        }
    }
}