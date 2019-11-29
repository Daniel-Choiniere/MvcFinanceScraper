namespace mvcScraper.Models
{
    public class Stock
    {
        public string Symbol { get; set; }
        public string LastPrice { get; set; }
        public string Change { get; set; }
        public string Currency { get; set; }
        public System.DateTime DataCollectedOn { get; set; }
        public string Volume { get; set; }
        public string AvgVol3m { get; set; }
        public string MarketCap { get; set; }
      
        
    }
}