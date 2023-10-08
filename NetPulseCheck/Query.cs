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
                        logger.WriteLog("Destination host unreachable" + separator + logText);
                        return "Destination host unreachable";
                    case IPStatus.DestinationUnreachable:
                        logger.WriteLog("Destination unreachable" + separator + logText);
                        return "Destination unreachable";
                    case IPStatus.TimedOut:
                        logger.WriteLog("Destination timed out" + separator + logText);
                        return "Destination timed out";
                    default:
                        logger.WriteLog(logText);
                        return "" + pingReply.RoundtripTime;
                }
            }
            catch
            {
                logger.WriteLog(logText);

                while (pingReply.Status == IPStatus.DestinationHostUnreachable)
                {
                    return "Destination host unreachable";
                }

                return logText;
            }
        }
    }
}
