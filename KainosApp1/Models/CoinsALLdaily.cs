using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KainosApp1.Models
{
    public class CoinsALLdaily
    {
        public List<CoinsBTC_daily> btcDailyAll { get; set; }
        public List<CoinsLTC_daily> ltcDailyAll { get; set; }
        public List<CoinsETH_daily> ethDailyAll { get; set; }
    }
}