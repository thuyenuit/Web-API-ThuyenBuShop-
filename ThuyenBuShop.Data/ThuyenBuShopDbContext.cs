using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThuyenBuShop.Model.Models;

namespace ThuyenBuShop.Data
{
    public class ThuyenBuShopDbContext: DbContext
    {
        public ThuyenBuShopDbContext()
            : base("ThuyenBuShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false; // cấu hình, khi include bảng cha thì sẽ khong include bản con nữa
        }

        public DbSet<Footer> Footers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategorys { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SupportOnline> SupportOnlines { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<VisitorStatistic> VisitorStatistices { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        { 
            
        }

    }
}
