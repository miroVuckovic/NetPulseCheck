using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace NetPulseCheck
{
    internal class Query
    {
        Logger logger = new Logger();

        private string hostname;
        private int timeout;
        private string dnsName;

        public Query(string hostname, int timeout, string dnsName)
        {
            this.hostname = hostname;
            this.timeout = timeout;
            this.dnsName = dnsName;
        }

        public string PingTargets()
        {
            Ping ping = new();

            PingReply pingReply = ping.Send(hostname, timeout);

            char separator = ';';

            string logText = hostname + separator + pingReply.RoundtripTime + " ms" + separator +  "(" + dnsName + ")";

            try
            {
                switch (pingReply.Status)
                {
                    case IPStatus.DestinationHostUnreachable:
                        return "Destination host unreachable";
                    case IPStatus.DestinationUnreachable:
                        return "Destination unreachable";
                    case IPStatus.TimedOut:
                        return "Destination timed out";
                    default:
                        return "" + pingReply.RoundtripTime;
                }
            }
            catch
            {
                while (pingReply.Status == IPStatus.DestinationHostUnreachable)
                {
                    return "Destination host unreachable";
                }
                return "-";
            }
            
        }
    }
}
