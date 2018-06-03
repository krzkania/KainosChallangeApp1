using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace KainosApp1.Models
{
    public class CoinsLTC_daily
    {
        public DateTime time { get; set; }
        public float average { get; set; }
    }
}