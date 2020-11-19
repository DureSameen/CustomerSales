using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;

namespace APiTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var json=File.ReadAllText(@"payloads\payload1.json");
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "https://localhost:44364/api/customersales";
            using var client = new HttpClient();

            var response =   client.PostAsync(url, data).Result;

            string result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
        }
    }
}
