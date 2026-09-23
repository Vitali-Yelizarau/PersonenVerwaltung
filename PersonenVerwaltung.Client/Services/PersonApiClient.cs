using PersonenVerwaltung.Client.Configuration;
using PersonenVerwaltung.Client.Models;
using System.Net.Http.Json;

namespace PersonenVerwaltung.Client.Services
{
    public static class PersonApiClient
    {
        private static readonly ClientSettings _settings = ClientSettingsLoader.Load();
        private static readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri(_settings.ApiBaseUrl)
        };

        public static async Task<List<PersonListItem>> GetPersonsAsync(string? name = null)
        {
            var url = "api/person";
            if (!string.IsNullOrWhiteSpace(name))
            {
                url += $"?name={Uri.EscapeDataString(name)}";
            }

            var result = await _httpClient.GetFromJsonAsync<List<PersonListItem>>(url);
            return result ?? [];
        }

        public static async Task<PersonDetail?> GetPersonByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"api/person/{id}");

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<PersonDetail>();
        }

        public static async Task UpdatePersonNameAsync(int id, string name)
        {
            var request = new UpdatePersonNameRequest { Name = name };
            var response = await _httpClient.PutAsJsonAsync($"api/person/{id}/name", request);
            response.EnsureSuccessStatusCode();
        }

        public static async Task<PersonDetail?> CreatePersonAsync(CreatePersonRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync("api/person", request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<PersonDetail>();
        }

        public static async Task DeletePersonAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/person/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}