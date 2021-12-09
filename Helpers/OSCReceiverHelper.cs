using SharpOSC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSC_Test.Helpers
{
   public class OSCReceiverHelper
    {
        private static OSCReceiverHelper _instance { get; set; }
        public static OSCReceiverHelper Instance
        {
            get
            {
                return _instance ?? (_instance = new OSCReceiverHelper());
            }
        }

        public void Start()
        {
            HandleOscPacket cb = delegate (OscPacket packet)
            {
                var msg = ((OscMessage)packet).Arguments[0].ToString();
                Console.WriteLine(msg);
            }; 
            var l1 = new UDPListener(10001, cb);
        }
    }
}












































































































