using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace servicehttpclient.model
{
    public class httpclientmodel
    {

        public async Task<string> GetProductAsync(string path)
        {
            HttpClient client = new HttpClient();
            
            string Hello = "";
            client.BaseAddress = new Uri("http://172.18.0.6:5000/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                HttpResponseMessage response = await client.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    Hello = await response.Content.ReadAsStringAsync();
                }
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Hello;

        }

    }
}