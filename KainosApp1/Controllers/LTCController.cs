using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.IO;
using Newtonsoft.Json;
using KainosApp1.Models;

namespace KainosApp1.Controllers
{
    public class LTCController : ApiController
    {
        public List<CoinsLTC_daily> GetLTC_daily()
        {
            string url_LTCdaily = "https://apiv2.bitcoinaverage.com/indices/local/history/LTCUSD?period=daily&format=json";
            string json_LTCdaily;

            using (var webClientLTC = new WebClient())
            {
                json_LTCdaily = webClientLTC.DownloadString(url_LTCdaily);
            }
            List<CoinsLTC_daily> dailyLTC = JsonConvert.DeserializeObject<List<CoinsLTC_daily>>(json_LTCdaily);
            return dailyLTC;
        }

        public List<CoinsLTC_monthly> GetLTC_monthly()
        {
            string url_LTCmonthly = "https://apiv2.bitcoinaverage.com/indices/local/history/LTCUSD?period=monthly&format=json";
            string json_LTCmonthly;

            using (var webClientLTC = new WebClient())
            {
                json_LTCmonthly = webClientLTC.DownloadString(url_LTCmonthly);
            }
            List<CoinsLTC_monthly> monthlyLTC = JsonConvert.DeserializeObject<List<CoinsLTC_monthly>>(json_LTCmonthly);
            return monthlyLTC ;
        }

        public List<CoinsLTC_allTime> GetLTC_allTime()
        {
            string url_LTCallTime = "https://apiv2.bitcoinaverage.com/indices/local/history/LTCUSD?period=alltime&format=json";
            string json_LTCallTime;

            using (var webClientLTC = new WebClient())
            {
                json_LTCallTime = webClientLTC.DownloadString(url_LTCallTime);
            }
            List<CoinsLTC_allTime> allTimeLTC = JsonConvert.DeserializeObject<List<CoinsLTC_allTime>>(json_LTCallTime);
            return allTimeLTC;
        }
    }
}
