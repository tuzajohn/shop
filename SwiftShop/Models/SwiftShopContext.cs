using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SwiftShop.Models
{
    public class SwiftShopContext : DbContext
    {
        public SwiftShopContext() :base ("SwiftshopConnectionString")
        {
            
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<AlternateProduct> AlternateProducts { get; set; }
        public virtual DbSet<Buyer> Buyers { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<SupportImage> SupportImages { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
    }
}