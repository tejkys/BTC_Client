using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using BTC_Client.Dtos;

namespace BTC_Client.Services
{
    public class BtcTrackerService
    {
        private static readonly HttpClient Client = new();
        private const string Url = "https://api.coindesk.com/v1/bpi/currentprice.json";

        public async Task<BitcoinResponse?> GetBitcoinDataAsync()
        {
            var response = await Client.GetAsync(Url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<BitcoinResponse>();
        }
    }
}
