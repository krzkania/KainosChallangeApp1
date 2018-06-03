using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KainosApp1.Models
{
    public class CoinsALLmonthly
    {
        public List<CoinsBTC_monthly> btcMonthlyAll { get; set; }
        public List<CoinsLTC_monthly> ltcMonthlyAll { get; set; }
        public List<CoinsETH_monthly> ethMonthlyAll { get; set; }
    }
}