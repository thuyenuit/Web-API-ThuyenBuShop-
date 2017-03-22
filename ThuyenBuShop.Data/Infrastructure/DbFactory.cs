namespace ThuyenBuShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ThuyenBuShopDbContext dbContext;

        public ThuyenBuShopDbContext Init()
        {
            return dbContext??(dbContext =new ThuyenBuShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}