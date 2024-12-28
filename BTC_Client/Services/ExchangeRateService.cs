using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BTC_Client.Dtos;
using static System.Windows.Forms.LinkLabel;

namespace BTC_Client.Services
{
    public class ExchangeRateService
    {
        private static readonly HttpClient Client = new();
        private const string Url = "https://www.cnb.cz/en/financial_markets/foreign_exchange_market/exchange_rate_fixing/daily.txt";

        public async Task<float> GetRateForCZKEURAsync()
        {
            var response = await Client.GetAsync(Url);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            var match = Regex.Match(data, @"EUR\|(.*)\n");
            if (match.Success)
            { 
                return float.Parse(match.Groups[1].Value);
            }

            return 0;
        }
    }
}
