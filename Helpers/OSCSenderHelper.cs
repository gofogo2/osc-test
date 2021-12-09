using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace OSC_Test.Helpers
{
    public class OSCSenderHelper
    {
        private static OSCSenderHelper _instance { get; set; }
        public static OSCSenderHelper Instance
        {
            get
            {
                return _instance ?? (_instance = new OSCSenderHelper());
            }
        }

        public void Send()
        {
            var sender = new SharpOSC.UDPSender("192.168.0.", 55555);
            var sender = new SharpOSC.UDPSender("192.168.0.21", 10001);
            var msg = new SharpOSC.OscMessage("/test/", 23.42f);
            sender.Send(msg);
        }

        public void SendAll()
        {
            
            var list = SampleData.Instance.ips;
            var rd = new Random().Next(0, 4);
            for (int i=3;i<253;i++)
            {
                try
                {
                    var sender = new SharpOSC.UDPSender($"192.168.0.{i}", 10001);
                    var msg = new SharpOSC.OscMessage("/test/", rd);
                    sender.Send(msg);
                }catch(Exception e)
                {
                    
                }
            }
        }
    }
}
