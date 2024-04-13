using ISP.Engine.Helpers;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace ISP.Engine.Network {
    internal static class Network {
        /// <summary>
        /// GET запрос
        /// </summary>
        /// <param name="link">Ссылка</param>
        /// <returns></returns>
        public static string GET(string link) {
            return new StreamReader(((HttpWebRequest)WebRequest.Create(link)).GetResponse().GetResponseStream()).ReadToEnd();
        }
        private static void ServiceManager() {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
        }
        /// <summary>
        /// POST запрос
        /// </summary>
        /// <param name="url"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static string POST(string url, string parameters) {
            ServiceManager();
            var req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.Timeout = 100000;
            req.UserAgent = Links.UserAgent;
            req.Referer = Links.Referer;
            req.UserAgent = "Mozilla/5.0 (compatible; U; ABrowse 0.6; Syllable) AppleWebKit/420+ (KHTML, like Gecko)";
            req.ContentType = "application/x-www-form-urlencoded";
            byte[] sentData = Encoding.UTF8.GetBytes(parameters);
            req.ContentLength = sentData.Length;
            Stream sendStream = req.GetRequestStream();
            sendStream.Write(sentData, 0, sentData.Length);
            sendStream.Close();

            var res = req.GetResponse();
            var ReceiveStream = res.GetResponseStream();
            var sr = new StreamReader(ReceiveStream, Encoding.UTF8);

            var read = new char[256];
            int count = sr.Read(read, 0, 256);
            string outs = string.Empty;
            while (count > 0) {
                string str = new string(read, 0, count);
                outs += str;
                count = sr.Read(read, 0, 256);
            }
            return outs;
        }
        public static string HttpRequest(string link) {
            ServiceManager();
            var request = (HttpWebRequest)WebRequest.Create(link);
            request.Referer = Links.Referer;
            request.UserAgent = Links.UserAgent;
            return new StreamReader(request.GetResponse().GetResponseStream()).ReadToEnd();
        }
    }
}
