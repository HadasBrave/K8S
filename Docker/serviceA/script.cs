namespace ServiceA
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Text.Json;
    using Newtonsoft.Json.Linq;

    class Program
    {
        static async Task<string> FetchBitcoinValue()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://api.coindesk.com/v1/bpi/currentprice/BTC.json");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(responseBody);
                return json["bpi"]["USD"]["rate"].ToString();
            }
        }

        static async Task Main(string[] args)
        {
            List<double> values = new List<double>();
            double sum = 0;
            int minutesSinceLastAvgPriceUpdate = 0;
            const int UPDATE_INTERVAL = 10;
            const int POLL_INTERVAL = 1;
            while (true)
            {
                try
                {
                    string bitcoinValue = await FetchBitcoinValue();
                    double currentPrice = double.Parse(bitcoinValue.Replace(",", ""));
                    logBitcoinUSDPrice(currentPrice);
                    Console.WriteLine(minutesSinceLastAvgPriceUpdate);
                    sum += currentPrice;
                    await Task.Delay(TimeSpan.FromSeconds(POLL_INTERVAL));
                    minutesSinceLastAvgPriceUpdate++;
                    if (minutesSinceLastAvgPriceUpdate == UPDATE_INTERVAL)
                    {
                        double averagePrice = sum / UPDATE_INTERVAL;
                        Console.WriteLine($"Average value for the last 10 minutes: {averagePrice}");
                        sum = 0;
                        minutesSinceLastAvgPriceUpdate = 0;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
        }
        static void logBitcoinUSDPrice(double bitcoinUSDPrice) 
        {
            Console.WriteLine($"Bitcoin value: {bitcoinUSDPrice}");
        }
    }
}