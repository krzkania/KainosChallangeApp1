using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.IO;
using Newtonsoft.Json;
using KainosApp1.Models;

namespace KainosApp1.Controllers
{
    public class BTCController : ApiController
    {
        public List<CoinsBTC_daily> GetBTC_daily()
        {
            string url_BTCdaily = "https://apiv2.bitcoinaverage.com/indices/local/history/BTCUSD?period=daily&format=json";
            string json_BTCdaily;

          using (var webClientBTC = new WebClient())
            {
                json_BTCdaily = webClientBTC.DownloadString(url_BTCdaily);
            }
            //CoinsBTC dailyBTC = JsonConvert.DeserializeObject<CoinsBTC>(json_BTCdaily);
            List<CoinsBTC_daily> dailyBTC = JsonConvert.DeserializeObject<List<CoinsBTC_daily>>(json_BTCdaily);
            return dailyBTC;
        }

        public List<CoinsBTC_monthly> GetBTC_monthly()
        {
            string url_BTCmonthly = "https://apiv2.bitcoinaverage.com/indices/local/history/BTCUSD?period=monthly&format=json";
            string json_BTCmonthly;

            using (var webClientBTC = new WebClient())
            {
                json_BTCmonthly = webClientBTC.DownloadString(url_BTCmonthly);
            }
            List<CoinsBTC_monthly> monthlyBTC = JsonConvert.DeserializeObject<List<CoinsBTC_monthly>>(json_BTCmonthly);
            return monthlyBTC;
            //return new List<CoinsBTC_monthly>();

        }

        public List<CoinsBTC_allTime> GetBTC_allTime()
        {
            string url_BTCalltime = "https://apiv2.bitcoinaverage.com/indices/local/history/BTCUSD?period=alltime&format=json";
            string json_BTCallTime;

            using (var webClientBTCallTime = new WebClient())
            {
                json_BTCallTime = webClientBTCallTime.DownloadString(url_BTCalltime);
            }
            List<CoinsBTC_allTime> allTimeBTC_dzialaj = JsonConvert.DeserializeObject<List<CoinsBTC_allTime>>(json_BTCallTime);

            //List<CoinsBTC_allTime> allTimeBTC = JsonConvert.DeserializeObject<List<CoinsBTC_allTime>>(json_BTCallTime);
            return allTimeBTC_dzialaj;
        }
    }
}
