using System.Net;
using System.Net.NetworkInformation;

namespace sms.Utils
{
    public static class ConnectionUtil
    {
        public static bool net_available = NetworkInterface.GetIsNetworkAvailable();

        public static bool CheckConnection()
        {
            if (net_available)
                try
                {
                    using (var client = new WebClient())
                    using (client.OpenRead("http://google.com/generate_204"))
                    {
                        return true;
                    }
                }
                catch
                {
                    return false;
                }

            return false;
        }
    }
}