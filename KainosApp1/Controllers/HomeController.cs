using KainosApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace KainosApp1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            
            
                ViewBag.Title = "Home Page";
                LTCController ltcContrDaily = new LTCController();
                BTCController btcContrDaily = new BTCController();
                ETHController ethContrDaily = new ETHController();
                CoinsTrends allContrDaily = new CoinsTrends();
                allContrDaily.btcDailyAll = btcContrDaily.GetBTC_daily();
                

                var diff = allContrDaily.btcDailyAll.Max(x => x.time).Date - allContrDaily.btcDailyAll.Min(x => x.time).Date;
                if (diff < TimeSpan.Zero)
                {
                    allContrDaily.BTC = false;
                }
                else
                {                    
                    var date = allContrDaily.btcDailyAll.Min(x => x.time).Date;
                    allContrDaily.btcDailyAll = allContrDaily.btcDailyAll.Where(x => x.time.Date > date).ToList();
                    var trend = allContrDaily.btcDailyAll.Max(x => x.average) - allContrDaily.btcDailyAll.Min(x => x.average);
                    allContrDaily.BTC = true;
                }

                allContrDaily.ethDailyAll = ethContrDaily.GetETH_daily();
            var diffETH = allContrDaily.ethDailyAll.Max(x => x.time).Date - allContrDaily.ethDailyAll.Min(x => x.time).Date;
            if (diffETH < TimeSpan.Zero)
            {
                allContrDaily.ETH = false;
            }
            else
            {
                var date = allContrDaily.ethDailyAll.Min(x => x.time).Date;
                allContrDaily.ethDailyAll = allContrDaily.ethDailyAll.Where(x => x.time.Date > date).ToList();
                var trend = allContrDaily.ethDailyAll.Max(x => x.average) - allContrDaily.ethDailyAll.Min(x => x.average);
                allContrDaily.ETH = true;
            }


            allContrDaily.ltcDailyAll = ltcContrDaily.GetLTC_daily();
            var diffLTC = allContrDaily.ltcDailyAll.Max(x => x.time).Date - allContrDaily.ltcDailyAll.Min(x => x.time).Date;
            if (diffLTC < TimeSpan.Zero)
            {
                allContrDaily.LTC = false;
            }
            else
            {
                var date = allContrDaily.ltcDailyAll.Min(x => x.time).Date;
                allContrDaily.ltcDailyAll = allContrDaily.ltcDailyAll.Where(x => x.time.Date > date).ToList();
                var trend = allContrDaily.ltcDailyAll.Max(x => x.average) - allContrDaily.ltcDailyAll.Min(x => x.average);
                allContrDaily.BTC = true;
            }
            return View(allContrDaily);
            
            
        }
        public ActionResult IndexBTCdaily()
        {
            ViewBag.Title = "Home Page";
            BTCController btcContrDaily = new BTCController();
            return View(btcContrDaily.GetBTC_daily());
        }
        public ActionResult IndexBTCmonthly()
        {
            ViewBag.Title = "Home Page";
            BTCController btcContrMonthly = new BTCController();
            return View(btcContrMonthly.GetBTC_monthly());
        }
        public ActionResult IndexBTCallTime()
        {
            ViewBag.Title = "Home Page";
            BTCController btcContrAllTime = new BTCController();
            return View(btcContrAllTime.GetBTC_allTime());
        }
        public ActionResult IndexETHdaily()
        {
            ViewBag.Title = "Home Page";
            ETHController ethContrDaily = new ETHController();
            return View(ethContrDaily.GetETH_daily());
        }
        public ActionResult IndexETHmonthly()
        {
            ViewBag.Title = "Home Page";
            ETHController ethContrMonthly = new ETHController();
            return View(ethContrMonthly.GetETH_monthly());
        }
        public ActionResult IndexETHallTime()
        {
            ViewBag.Title = "Home Page";
            ETHController ethContrAllTime = new ETHController();
            return View(ethContrAllTime.GetETH_allTime());
        }
        public ActionResult IndexLTCdaily()
        {
            ViewBag.Title = "Home Page";
            LTCController ltcContrDaily = new LTCController();
            return View(ltcContrDaily.GetLTC_daily());
        }
        public ActionResult IndexLTCmonthly()
        {
            ViewBag.Title = "Home Page";
            LTCController ltcContrMonthly = new LTCController();
            return View(ltcContrMonthly.GetLTC_monthly());
        }
        public ActionResult IndexLTCallTime()
        {
            ViewBag.Title = "Home Page";
            LTCController ltcContrAllTime = new LTCController();
            return View(ltcContrAllTime.GetLTC_allTime());
        }

        public ActionResult IndexAlldaily()
        {
            ViewBag.Title = "Home Page";
            LTCController ltcContrDaily = new LTCController();
            BTCController btcContrDaily = new BTCController();
            ETHController ethContrDaily = new ETHController();
            CoinsALLdaily allContrDaily = new CoinsALLdaily();
            allContrDaily.btcDailyAll = btcContrDaily.GetBTC_daily();
            allContrDaily.ethDailyAll = ethContrDaily.GetETH_daily();
            allContrDaily.ltcDailyAll = ltcContrDaily.GetLTC_daily();
            return View(allContrDaily);
        }
        public ActionResult IndexAllmonthly()
        {
            ViewBag.Title = "Home Page";
            LTCController ltcContrMonthly = new LTCController();
            BTCController btcContrMonthly = new BTCController();
            ETHController ethContrMonthly = new ETHController();
            CoinsALLmonthly allContrMonthly = new CoinsALLmonthly();
            allContrMonthly.btcMonthlyAll = btcContrMonthly.GetBTC_monthly();
            allContrMonthly.ethMonthlyAll = ethContrMonthly.GetETH_monthly();
            allContrMonthly.ltcMonthlyAll = ltcContrMonthly.GetLTC_monthly();
            return View(allContrMonthly);
        }
        public ActionResult IndexAllallTime()
        {
            ViewBag.Title = "Home Page";
            LTCController ltcContrAllTime = new LTCController();
            BTCController btcContrAllTime = new BTCController();
            ETHController ethContrAllTime = new ETHController();
            CoinsALLallTime allContrAllTime = new CoinsALLallTime();
            allContrAllTime.btcAllTimeAll = btcContrAllTime.GetBTC_allTime();
            allContrAllTime.ethAllTimeAll = ethContrAllTime.GetETH_allTime();
            allContrAllTime.ltcAllTimeAll = ltcContrAllTime.GetLTC_allTime();
            return View(allContrAllTime);
        }

        public ActionResult DailyTrends()
        {
            ViewBag.Title = "Home Page";
            LTCController ltcContrDaily = new LTCController();
            BTCController btcContrDaily = new BTCController();
            ETHController ethContrDaily = new ETHController();
            CoinsALLdaily allContrDaily = new CoinsALLdaily();
            allContrDaily.btcDailyAll = btcContrDaily.GetBTC_daily();

            var diff = allContrDaily.btcDailyAll.Max(x => x.time).Date - allContrDaily.btcDailyAll.Min(x => x.time).Date;
            if(diff < TimeSpan.Zero)
            {
                //MNIEJSZE
            }
            else
            {
                //WIEKSZE
                var date = allContrDaily.btcDailyAll.Min(x => x.time).Date;

                allContrDaily.btcDailyAll = allContrDaily.btcDailyAll.Where(x => x.time.Date > date).ToList();
                var trend = allContrDaily.btcDailyAll.Max(x => x.average) - allContrDaily.btcDailyAll.Min(x => x.average);                
            }

            allContrDaily.ethDailyAll = ethContrDaily.GetETH_daily();
            allContrDaily.ltcDailyAll = ltcContrDaily.GetLTC_daily();
            return View(allContrDaily);
        }

    }
}
