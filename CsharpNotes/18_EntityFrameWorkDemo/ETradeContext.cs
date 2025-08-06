using System.Data.Entity;

namespace _18_EntityFrameWorkDemo
{
    internal class ETradeContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
