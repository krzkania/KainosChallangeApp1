using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KainosApp1.Models
{
    public class CoinsTrends
    {
        public List<CoinsBTC_daily> btcDailyAll { get; set; }
        public List<CoinsLTC_daily> ltcDailyAll { get; set; }
        public List<CoinsETH_daily> ethDailyAll { get; set; }
        public bool BTC { get; set; }
        public bool ETH { get; set; }
        public bool LTC { get; set; }
    }
}