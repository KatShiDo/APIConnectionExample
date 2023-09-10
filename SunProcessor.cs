using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIConnectionExample
{
    public class SunProcessor
    {
        public static async Task<SunModel> LoadSunInfo(DateTime date)
        {
            string url = $"https://api.sunrise-sunset.org/json?lat=55.45&lng=37.36&date={date}";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    SunResultModel result = await response.Content.ReadAsAsync<SunResultModel>();

                    return result.Results;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
