using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPulseCheck
{
    internal class Globals
    {
        public static string logPath = string.Empty;

        #region Messages
        public static string MsgStrings(int status)
        {
            switch (status)
            {
                case 0:
                    return "Host unreachable";
                case 1:
                    return "Connection OK";
                default:
                    return "Connection OK";
            }
        }

        #endregion
    }
}
