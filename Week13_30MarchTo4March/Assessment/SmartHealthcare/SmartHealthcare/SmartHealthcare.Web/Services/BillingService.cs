using System.Net.Http;
using System.Net.Http.Json;
using SmartHealthcare.Models.Entities;

namespace SmartHealthcare.Web.Services
{
    public class BillingService
    {
        private readonly HttpClient _httpClient;

        public BillingService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Get all bills
        public async Task<IEnumerable<Bill>> GetAllBillsAsync()
        {
            var response = await _httpClient.GetAsync("http://localhost:5125/api/Bill");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IEnumerable<Bill>>();
        }

        // Create a new bill
        public async Task CreateBillAsync(Bill bill)
        {
            var response = await _httpClient.PostAsJsonAsync("http://localhost:5125/api/Bill", bill);
            response.EnsureSuccessStatusCode();
        }
    }
}