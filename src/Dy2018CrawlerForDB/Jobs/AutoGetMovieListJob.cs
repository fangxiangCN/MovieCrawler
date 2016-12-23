﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AngleSharp.Parser.Html;
using Dy2018CrawlerWithDB.Models;
using Pomelo.AspNetCore.TimedJob;

namespace Dy2018CrawlerWithDB.Jobs
{
    public class AutoGetMovieListJob:Job
    {
       
        [Invoke(Begin = "2016-12-22 9:30", Interval = 1000 * 3600*2, SkipWhileExecuting =true)]
        public void Run()
        {
            LogHelper.Info("Start crawling");
            Btdytt520CrawlerHelper.CrawlHostMovieInfo();
            Dy2018CrawlerHelper.CrawlLatestMovieInfo();
            Dy2018CrawlerHelper.CrawlHotMovie();

            LogHelper.Info("Finish crawling");
        }

    
    }
}
