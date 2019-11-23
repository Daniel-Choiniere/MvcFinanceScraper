using StockData.Models;
using Microsoft.EntityFrameworkCore;

namespace StockData
{
    public class StockContext : DbContext
    {
        public StockContext(DbContextOptions options) : base(options) {}
        
        public DbSet<Stock> Stocks { get; set; }
         
    }
}