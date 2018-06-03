using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KainosApp1.Models
{
    public class CoinsALLallTime
    {
        public List<CoinsBTC_allTime> btcAllTimeAll { get; set; }
        public List<CoinsLTC_allTime> ltcAllTimeAll { get; set; }
        public List<CoinsETH_allTime> ethAllTimeAll { get; set; }      

    }
}