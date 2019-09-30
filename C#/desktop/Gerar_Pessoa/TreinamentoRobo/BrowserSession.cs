using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TreinamentoRobo
{
    public class BrowserSession
    {
        public string Timeout = "24000";

        public string HtmlResponse { get; private set; }
        public string HtmlReferer { get; private set; }
        public bool HtmlRedirect { get; private set; }
        public string HtmlPost { get; private set; }
        [JsonIgnore]
        public CookieContainer CookieContainer { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Domain { get; set; }
        [JsonIgnore]
        public HtmlWeb Client { get; }
        public string Url { get; set; }
        public bool IeHeader { get; set; }

        private bool _isImage;

        private string _path;


        public BrowserSession()
        {
            if (Thread.CurrentThread.CurrentCulture.Name != "pt-BR")
                Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            CookieContainer = new CookieContainer();

            Client = new HtmlWeb { UseCookies = true, PreRequest = OnRequest, PostResponse = OnResponse };
        }
        public string Get(string url, bool htmlRedirect = false)
        {
            try
            {
                HtmlRedirect = htmlRedirect;
                var param = string.Empty;

                if (!string.IsNullOrEmpty(url))
                    param = url.Substring(0, 4);

                Client.Load(!param.Contains("http") ? string.Concat(Url, url) : url);
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.Timeout)
                    throw new Exception(string.Concat("Timeout - ", e.Message));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return HtmlResponse;
        }
        public string GetImage(string url, Encoding encoding = null, bool? redirectAction = null, int? timeout = null, string path = null)
        {
            try
            {
                _isImage = true;
                _path = path;

                Client.Load(!url.Contains("http") ? string.Concat(Url, url) : url);

                _isImage = false;

                return HtmlResponse;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Post(string url, string parameters = null, bool htmlRedirect = false, string referer = null)
        {
            try
            {
                HtmlRedirect = htmlRedirect;
                HtmlPost = parameters;
                HtmlReferer = referer;

                Client.Load(!url.Contains("http") ? string.Concat(Url, url) : url, "POST");
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.Timeout)
                    throw new Exception(string.Concat("Timeout - ", e.Message));

                HttpWebResponse errorResponse = e.Response as HttpWebResponse;

                if (errorResponse == null)
                    throw; //errorResponse not of type HttpWebResponse

                string responseContent = "";

                using (StreamReader r = new StreamReader(errorResponse.GetResponseStream()))
                {
                    responseContent = r.ReadToEnd();
                }

                Console.WriteLine("The server at {0} returned {1}", errorResponse.ResponseUri, errorResponse.StatusCode);

                Console.WriteLine("With headers:");
                foreach (string key in errorResponse.Headers.AllKeys)
                {
                    Console.WriteLine("\t{0}:{1}", key, errorResponse.Headers[key]);
                }

                Console.WriteLine(responseContent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return HtmlResponse;
        }
        private void OnResponse(HttpWebRequest request, HttpWebResponse response)
        {
            if (_isImage)
            {
                using (var reader = new BinaryReader(response.GetResponseStream()))
                {
                    Byte[] lnByte = reader.ReadBytes(1 * 1024 * 1024 * 10);
                    string file = new Random(99999999).Next().ToString() + "_" + DateTime.Now.Ticks + ".jpg";
                    file = _path + file;
                    using (FileStream lxFS = new FileStream(file, FileMode.Create))
                    {
                        lxFS.Write(lnByte, 0, lnByte.Length);
                    }

                    HtmlResponse = file;
                }
            }
            else
            {
                StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("iso-8859-1"));
                HtmlResponse = sr.ReadToEnd();

                //GC.Collect();
                //GC.WaitForPendingFinalizers();
            }
        }
        private bool OnRequest(HttpWebRequest request)
        {
            if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
            {
                var credentialCache = new CredentialCache
                    {
                        {request.RequestUri, "Basic", new NetworkCredential(Username, Password, Domain)},
                        {request.RequestUri, "Negotiate", new NetworkCredential(Username, Password, Domain)}
                    };
                request.Credentials = credentialCache;
            }
            else
            {
                request.Credentials = CredentialCache.DefaultNetworkCredentials;
            }

            request.AllowAutoRedirect = HtmlRedirect;
            request.CookieContainer = CookieContainer;
            request.Referer = HtmlReferer;
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.KeepAlive = true;

            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3";
            request.Headers.Set(HttpRequestHeader.AcceptLanguage, "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3770.100 Safari/537.36";
            request.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
            request.Headers.Set(HttpRequestHeader.Pragma, "no-cache");
            request.Timeout = Convert.ToInt32(Timeout);

            request.Headers.Add("Upgrade-Insecure-Requests", @"1");
            request.Headers.Add("Purpose", @"prefetch");

            HtmlReferer = request.RequestUri.AbsoluteUri;

            if (request.Method == "POST" && !string.IsNullOrEmpty(HtmlPost))
            {
                request.ContentType = "application/x-www-form-urlencoded";

                var buffer = Encoding.UTF8.GetBytes(HtmlPost);

                request.ContentLength = buffer.Length;

                using (var requestStream = request.GetRequestStream())
                {
                    requestStream.Write(buffer, 0, buffer.Length);
                }

                HtmlPost = null;
            }

            return true;
        }
        public void AddCookie(Cookie cookie, string urlBase = null)
        {
            CookieContainer.Add(new Uri(urlBase), cookie);
        }
        public void SetUrlBase(string urlBase)
        {
            Url = urlBase;
        }
    }
}
