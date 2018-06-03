using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KainosApp1.Models
{
    public class CoinsLTC_monthly
    {
        public DateTime time { get; set; }
        public float average { get; set; }
        public float open { get; set; }
        public float low { get; set; }
        public float high { get; set; }
    }
}