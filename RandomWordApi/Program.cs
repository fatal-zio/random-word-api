using EmployeeDataGenerator.Models;
using EmployeeDataGenerator.Utilities;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using System.Text;

internal class Program
{
    private static async Task Main(string[] args)
    { 
        var config = new ConfigurationBuilder().AddJsonFile("config.json", false, true).Build();
        var section = config.GetSection("ApiConfig");

        using var client = new HttpClient();
        var apiSettings = section.Get<ApiSettings>();
        var sb = new StringBuilder();
        var absolutePath = sb.Append(apiSettings.DefaultFileLocation);
        sb.Append(apiSettings.DefaultFileName);

        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));
        client.DefaultRequestHeaders.Add("X-Api-Key", apiSettings.ApiKey);

        var lastNames = await RestClient.GetEmployeeLastNames(client, apiSettings, apiSettings.DefaultEmployeeCount);
        var firstNames = await RestClient.GetEmployeeFirstNames(client, apiSettings, apiSettings.DefaultEmployeeCount);

        EmployeeCsvWriter.WriteEmployeeCsv(DataGenerator.GenerateEmployees(firstNames, lastNames), sb.ToString());
    }
}