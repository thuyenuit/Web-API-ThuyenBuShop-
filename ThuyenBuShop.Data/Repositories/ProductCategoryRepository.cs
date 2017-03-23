﻿using System.Collections.Generic;
using ThuyenBuShop.Data.Infrastructure;
using ThuyenBuShop.Model.Models;
using System.Linq;

namespace ThuyenBuShop.Data.Repositories
{
    public interface IProductCategoryRepository 
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {

        }


        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
        
    }

}