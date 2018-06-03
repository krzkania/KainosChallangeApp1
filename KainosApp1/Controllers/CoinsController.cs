using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.IO;
using Newtonsoft.Json;
using KainosApp1.Models;

namespace KainosApp1.Controllers
{
    public class CoinsController : ApiController
    {
       
        List<CoinsBTC_daily> BTCdata = new List<CoinsBTC_daily>();
        // GET: api/Coins
        public List<CoinsBTC_daily> Get()
        {
            return BTCdata;
        }

        // GET: api/Coins/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Coins
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Coins/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Coins/5
        public void Delete(int id)
        {
        }
    }
}
