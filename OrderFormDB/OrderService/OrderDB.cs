using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{
    public class OrderDB:DbContext
    {
        public OrderDB() : base("OrderDataBase") {
            Database.SetInitializer(
            new DropCreateDatabaseIfModelChanges<OrderDB>());
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Goods> GoodItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
