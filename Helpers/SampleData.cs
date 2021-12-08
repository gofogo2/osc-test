using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSC_Test.Helpers
{
    public class SampleData
    {
        private static SampleData _instance { get; set; }
        public static SampleData Instance
        {
            get
            {
                return _instance ?? (_instance = new SampleData());
            }
        }

        SampleData()
        {
            ips = new List<string>();
            MakeList();
        }

        public List<string> ips;

        public void MakeList()
        {
            ips.Add("192.168.0.7");
            ips.Add("192.168.0.8");
            ips.Add("192.168.0.9");
            ips.Add("192.168.0.10");
            ips.Add("192.168.0.12");
            ips.Add("192.168.0.13");
            ips.Add("192.168.0.14");
            ips.Add("192.168.0.15");
            ips.Add("192.168.0.16");
            ips.Add("192.168.0.17");
            ips.Add("192.168.0.18");
            ips.Add("192.168.0.19");
            ips.Add("192.168.0.20");
            ips.Add("192.168.0.21");
            ips.Add("192.168.0.23");
            ips.Add("192.168.0.24");
            ips.Add("192.168.0.25");
            ips.Add("192.168.0.26");
            ips.Add("192.168.0.27");
            ips.Add("192.168.0.28");
            ips.Add("192.168.0.29");
            ips.Add("192.168.0.30");
            ips.Add("192.168.0.31");
            ips.Add("192.168.0.32");
            ips.Add("192.168.0.33");
            ips.Add("192.168.0.34");
            ips.Add("192.168.0.35");
            ips.Add("192.168.0.36");
            ips.Add("192.168.0.37");
            ips.Add("192.168.0.38");
            ips.Add("192.168.0.39");
            ips.Add("192.168.0.40");
            ips.Add("192.168.0.41");
            ips.Add("192.168.0.42");
            ips.Add("192.168.0.43");
            ips.Add("192.168.0.45");
            ips.Add("192.168.0.49");
            ips.Add("192.168.0.50");
            ips.Add("192.168.0.51");
            ips.Add("192.168.0.52");
            ips.Add("192.168.0.53");
            ips.Add("192.168.0.54");
            ips.Add("192.168.0.55");
            ips.Add("192.168.0.56");
            ips.Add("192.168.0.57");
            ips.Add("192.168.0.58");
            ips.Add("192.168.0.59");
            ips.Add("192.168.0.60");
            ips.Add("192.168.0.61");
            ips.Add("192.168.0.62");
            ips.Add("192.168.0.63");
            ips.Add("192.168.0.64");
            ips.Add("192.168.0.65");
            ips.Add("192.168.0.66");
            ips.Add("192.168.0.67");
            ips.Add("192.168.0.68");
            ips.Add("192.168.0.69");
            ips.Add("192.168.0.70");
            ips.Add("192.168.0.71");
            ips.Add("192.168.0.72");
            ips.Add("192.168.0.73");
            ips.Add("192.168.0.74");
            ips.Add("192.168.0.75");
            ips.Add("192.168.0.76");
            ips.Add("192.168.0.77");
            ips.Add("192.168.0.78");
            ips.Add("192.168.0.79");
            ips.Add("192.168.0.80");
            ips.Add("192.168.0.82");
            ips.Add("192.168.0.83");
            ips.Add("192.168.0.84");
            ips.Add("192.168.0.85");
            ips.Add("192.168.0.86");
            ips.Add("192.168.0.87");
            ips.Add("192.168.0.88");
            ips.Add("192.168.0.91");
            ips.Add("192.168.0.92");
            ips.Add("192.168.0.93");
            ips.Add("192.168.0.94");
            ips.Add("192.168.0.95");
            ips.Add("192.168.0.96");
            ips.Add("192.168.0.98");
            ips.Add("192.168.0.100");
            ips.Add("192.168.0.101");
            ips.Add("192.168.0.102");
            ips.Add("192.168.0.103");
            ips.Add("192.168.0.104");
            ips.Add("192.168.0.105");
            ips.Add("192.168.0.106");
            ips.Add("192.168.0.107");
            ips.Add("192.168.0.108");
            ips.Add("192.168.0.109");
            ips.Add("192.168.0.110");
            ips.Add("192.168.0.111");
            ips.Add("192.168.0.112");
            ips.Add("192.168.0.114");
            ips.Add("192.168.0.139");
            ips.Add("192.168.0.188");
            ips.Add("192.168.0.189");
            ips.Add("192.168.0.190");
            ips.Add("192.168.0.191");
            ips.Add("192.168.0.193");
            ips.Add("192.168.0.194");
            ips.Add("192.168.0.195");
            ips.Add("192.168.0.196");
            ips.Add("192.168.0.197");
            ips.Add("192.168.0.198");
            ips.Add("192.168.0.199");
            ips.Add("192.168.0.200");
        }
    }
}
