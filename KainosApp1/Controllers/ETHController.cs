using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.IO;
using Newtonsoft.Json;
using KainosApp1.Models;

namespace KainosApp1.Controllers
{
    public class ETHController : ApiController
    {
        public List<CoinsETH_daily> GetETH_daily()
        {
            string url_ETHdaily = "https://apiv2.bitcoinaverage.com/indices/local/history/ETHUSD?period=daily&format=json";
            string json_ETHdaily;

            using (var webClientETH = new WebClient())
            {
                json_ETHdaily = webClientETH.DownloadString(url_ETHdaily);
            }           
            List<CoinsETH_daily> dailyBTC = JsonConvert.DeserializeObject<List<CoinsETH_daily>>(json_ETHdaily);
            return dailyBTC;
        }

        public List<CoinsETH_monthly> GetETH_monthly()
        {
            string url_ETHmonthly = "https://apiv2.bitcoinaverage.com/indices/local/history/BTCUSD?period=monthly&format=json";
            string json_ETHmonthly;

            using (var webClientETH = new WebClient())
            {
                json_ETHmonthly = webClientETH.DownloadString(url_ETHmonthly);
            }
            List<CoinsETH_monthly> monthlyETH = JsonConvert.DeserializeObject<List<CoinsETH_monthly>>(json_ETHmonthly);
            return monthlyETH;
        }

        public List<CoinsETH_allTime> GetETH_allTime()
        {
            string url_ETHallTime = "https://apiv2.bitcoinaverage.com/indices/local/history/ETHUSD?period=alltime&format=json";
            string json_ETHallTime;

            using (var webClientETH = new WebClient())
            {
                json_ETHallTime = webClientETH.DownloadString(url_ETHallTime);
            }
            List<CoinsETH_allTime> allTimeETH = JsonConvert.DeserializeObject<List<CoinsETH_allTime>>(json_ETHallTime);
            return allTimeETH;
        }
    }
}
