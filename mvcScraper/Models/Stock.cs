using System.ComponentModel.DataAnnotations;

namespace mvcScraper.Models
{
    public class Stock
    {
        public string Symbol { get; set; }
        
        [Display(Name = "Last Price")]
        public string LastPrice { get; set; }
        public string Change { get; set; }
        public string Currency { get; set; }
        
        [Display(Name = "Scrape Date")]
        public System.DateTime DataCollectedOn { get; set; }
        public string Volume { get; set; }
        
        [Display(Name = "Average Volume")]
        public string AvgVol3m { get; set; }
        
        [Display(Name = "Market Cap")]
        public string MarketCap { get; set; }
      
        
    }
}