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

        // Helper to set token
        public void SetToken(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        }

        public async Task<IEnumerable<Bill>> GetAllBillsAsync()
        {
            var response = await _httpClient.GetAsync("http://localhost:5125/api/Bill");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IEnumerable<Bill>>();
        }

        public async Task<Bill?> GetBillByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"http://localhost:5125/api/Bill/{id}");
            if (!response.IsSuccessStatusCode) return null;
            return await response.Content.ReadFromJsonAsync<Bill>();
        }

        public async Task CreateBillAsync(Bill bill)
        {
            var response = await _httpClient.PostAsJsonAsync("http://localhost:5125/api/Bill", bill);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateBillAsync(Bill bill)
        {
            var response = await _httpClient.PutAsJsonAsync($"http://localhost:5125/api/Bill/{bill.BillId}", bill);
            response.EnsureSuccessStatusCode();
        }
    }
}