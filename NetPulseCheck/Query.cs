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
        private string hostname;
        private int timeout;

        public Query(string hostname, int timeout)
        {
            this.hostname = hostname;
            this.timeout = timeout;
        }

        public string PingTargets()
        {
            Ping ping = new();

            PingReply pingReply = ping.Send(hostname, timeout);

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
