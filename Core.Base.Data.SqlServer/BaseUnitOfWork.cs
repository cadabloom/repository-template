﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Core.Base.Data.SqlServer.Factory;

namespace Core.Base.Data.SqlServer
{
    public class BaseUnitOfWork<T> : IUnitOfWork
        where T : DbContext
    {
        private readonly IContextFactory<T> contextFactory;
        private T dataContext;

        public BaseUnitOfWork(IContextFactory<T> databaseFactory)
        {
            contextFactory = databaseFactory;
            dataContext = DataContext;
        }

        protected T DataContext
        {
            get { return dataContext ?? (dataContext = contextFactory.Get()); }
        }

        public void Save()
        {
            dataContext.SaveChanges();
        }
    }
}
