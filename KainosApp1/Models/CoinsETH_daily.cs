using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace KainosApp1.Models
{
    public class CoinsETH_daily
    {
        public DateTime time { get; set; }
        public double average { get; set; }
    }
}