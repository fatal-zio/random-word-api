using EmployeeDataGenerator.Models;
using System.Text.Json;

namespace EmployeeDataGenerator.Utilities
{
    internal class RestClient
    {
        public static async Task<List<string>> GetEmployeeFirstNames(HttpClient client, ApiSettings apiSettings, int count)
        {
            var jsonResponse = await client.GetStringAsync($"{apiSettings.BaseUrl}{apiSettings.FirstNameUrl}{count}");

            return JsonSerializer.Deserialize<List<string>>(jsonResponse);
        }

        public static async Task<List<string>> GetEmployeeLastNames(HttpClient client, ApiSettings apiSettings, int count)
        {
            var jsonResponse = await client.GetStringAsync($"{apiSettings.BaseUrl}{apiSettings.LastNameUrl}{count}");

            return JsonSerializer.Deserialize<List<string>>(jsonResponse);
        }
    }
}
