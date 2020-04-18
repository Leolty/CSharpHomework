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
    class Program
    {
        static void Main(string[] args)
        {
            Crawler myCrawler = new Crawler();
            if (args.Length >= 1) myCrawler.startUrl = args[0];
            myCrawler.urls.Add(myCrawler.startUrl, false);//加入初始页面
            new Thread(myCrawler.Crawl).Start();

        }
    }
}
