using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using servicehttpclient.model;

namespace Service.Controllers
{
    [Route("api/edi/[controller]")]
    public class HelloController : Controller
    {
        httpclientmodel client = new httpclientmodel();
<<<<<<< HEAD
        string _address= "http://188.166.236.181:5001/api/selly/hello";
=======
        string _address= "http://172.18.0.6:5001/api/selly/hello";
>>>>>>> latihan_branch

        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            var result = await client.GetProductAsync(_address);

            return new string[] { "Hello Edi", result };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
