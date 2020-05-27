using Microsoft.EntityFrameworkCore;

namespace OrderApi.Models
{
    public class OrderContext : DbContext{
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItem>().HasKey(c => new{c.ItemID,c.OrderID});
        }

        public DbSet<Order> Orders {get;set;}
        public DbSet<OrderItem> OrderItems{get;set;}
    }
}