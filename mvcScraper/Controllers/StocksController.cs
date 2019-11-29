using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using mvcScraper.Models;

namespace mvcScraper.Controllers
{
    public class StocksController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Details()
        {
            Stock stock = new Stock()
            {
                Symbol = "BTC",
                LastPrice = "9,900",
                Change = "+5.73%",
                Currency = "USD",
                DataCollectedOn = DateTime.Now,
                Volume = "5.33M",
                AvgVol3m = "7.3M",
                MarketCap = "12B"
            };
 
            return View(stock);
        }
        
    }
} 