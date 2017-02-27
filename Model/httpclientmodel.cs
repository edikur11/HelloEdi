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
<<<<<<< HEAD
            client.BaseAddress = new Uri("http://188.166.236.181:5501/");
=======
            client.BaseAddress = new Uri("http://188.166.236.181/");
>>>>>>> 89fd1e4ace048dd6ca3b5765226108fe2d21f64b
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