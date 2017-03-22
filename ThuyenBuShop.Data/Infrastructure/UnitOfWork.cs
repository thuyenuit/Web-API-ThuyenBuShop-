﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuyenBuShop.Data.Infrastructure
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private ThuyenBuShopDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public ThuyenBuShopDbContext DbContext
        {
            get { return DbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit() {
            DbContext.SaveChanges();
        }
    }
}
