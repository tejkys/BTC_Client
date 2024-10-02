using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using BTC_Client.Dtos;

namespace BTC_Client.Services
{
    public class ApiService
    {
        private static readonly HttpClient Client = new();
        private const string Url = "https://localhost:7141";

        public async Task<List<BtcPriceDto>?> GetBtcSavedDataAsync()
        {
            var response = await Client.GetAsync($"{Url}/Data/Load");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<BtcPriceDto>>();
        }
        public async Task SaveBtcDataAsync(BtcPriceDto data)
        {
            var response = await Client.PostAsJsonAsync($"{Url}/Data/Save", data);
            response.EnsureSuccessStatusCode();
        }
        public async Task AddBtcDataRangeAsync(IEnumerable<BtcPriceDto> data)
        {
            var response = await Client.PostAsJsonAsync($"{Url}/Data/AddRange", data);
            response.EnsureSuccessStatusCode();
        }
        public async Task DeleteBtcDataAsync(long id)
        {
            var response = await Client.DeleteAsync($"{Url}/Data/Delete/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
