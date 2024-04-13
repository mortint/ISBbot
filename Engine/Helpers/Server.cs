using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace ISP.Engine.Helpers {
    public static class Server {
        /// <summary>
        /// Получить IP адрес
        /// </summary>
        /// <returns></returns>
        public static string GetIP() {
            var wc = new WebClient();

            var ip = wc.DownloadString("http://checkip.dyndns.com");

            var pattern = Regex.Match(ip, @"(?<=<body.*?>)[\w\W\s]*?(?=</body>)").Value;

            return pattern.Replace("Current IP Address:", "");
        }
        /// <summary>
        /// Получить HWID
        /// </summary>
        /// <returns></returns>
        public static string GetHWID() {
            return (from nic in NetworkInterface.GetAllNetworkInterfaces()
                    where nic.OperationalStatus == OperationalStatus.Up
                    select nic.GetPhysicalAddress().ToString()).FirstOrDefault();
        }
    }
}
