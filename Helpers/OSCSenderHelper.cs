using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var sender = new SharpOSC.UDPSender("localhost", 55555);
            var msg = new SharpOSC.OscMessage("/test/", 23.42f);
            sender.Send(msg);
        }
    }
}
