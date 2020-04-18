using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Crawler
{
    public class Crawler
    {
        public Hashtable urls = new Hashtable();
        public int count = 0;
        public string startUrl = "https://www.cnblogs.com/dstang2000/";
        public event Action<string> PageDownloaded;


        public void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }
                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面!");               
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                Parse(html);//解析,并加入新的链接
                Console.WriteLine("爬行结束");
            }
        }

        private string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                PageDownloaded(url);
                return html;
            }
            catch (Exception ex)
            {
                PageDownloaded(url + "   Error:" + ex.Message);
                
                //Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+\.html[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                if (strRef.Contains(startUrl))
                {
                    if (urls[strRef] == null) urls[strRef] = false;
                }
            }
        }
    }
}
