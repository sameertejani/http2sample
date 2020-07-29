using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading;

namespace http2sample.Controllers
{
    public class ValuesController : ApiController
    {
        static Random rnd = new Random();

        // GET api/values
        public IEnumerable<string> Get()
        {
            int randomNum = rnd.Next(1, 5000);
            Thread.Sleep(randomNum);
            return new string[] { "value1", "value2", randomNum.ToString() };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
