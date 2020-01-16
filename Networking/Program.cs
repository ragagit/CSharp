using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Diagnostics;

/*
Networking
A WebClient facade class for download/upload operations via HTTP
WebRequest, WebResponse
HttpClient for consuming HTTP web APIs
HttpListener for writing an HTTP server
SmtpClient for mail
Dns
TcpClient, UdpClient, TcpListener and Socket
*/
namespace CSharpS7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient wc = new WebClient();

            IPAddress[] ip = Dns.GetHostAddresses("www.google.com");

            wc.Headers.Add("CustomHeader", "this/iscustom");

            Console.WriteLine(wc.Headers.ToString());

            // foreach (IPAddress i in ip)
            //     Console.WriteLine(i);

            Console.WriteLine(ip[0]);

             Stream data = wc.OpenRead("http://"+ip[0]);

            Console.WriteLine(wc.ResponseHeaders.ToString());

            wc.QueryString.Add("q", Uri.EscapeDataString("c#"));
            wc.QueryString.Add("hl", "fr");

            wc.DownloadFile("http://google.com/search", "results.html");

            // Process.Start("results.html");


            // --- Stream
            StreamReader sr = new StreamReader(data);

            string str = sr.ReadToEnd();

            data.Close();

            //Console.WriteLine(str);


            // --- HttpClient

            Uri uri = new Uri("http://google.com");

            HttpClientHandler handler = new HttpClientHandler();

            handler.CookieContainer = new CookieContainer();

            handler.CookieContainer.Add(uri, new Cookie("cookie1", "value1"));

            HttpClient hc = new HttpClient(handler);

            HttpResponseMessage response = hc.GetAsync(uri).Result;
            Console.WriteLine(response.ToString());

            // --- Cookies

            CookieCollection cc = handler.CookieContainer.GetCookies(uri);

            foreach (Cookie c in cc)
            {
                Console.WriteLine(c.Name);
            }
        }
    }
}
