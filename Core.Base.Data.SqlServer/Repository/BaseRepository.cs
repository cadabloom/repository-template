﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Base.Data.SqlServer.Factory;
using System.Data.Entity;
using Core.Base.Data.SqlServer;

namespace Core.Base.Data.SqlServer.Repository
{
    public class BaseRepository<T, C> : Base<T>
        where T : class
        where C : DbContext
    {
        private C dbContext;
        protected IContextFactory<C> ContextFactory { get; set; }
        protected C Context
        {
            get { return dbContext ?? (dbContext = ContextFactory.Get()); }
        }

        public BaseRepository(IContextFactory<C> contextFactory)
            : base(new BaseUnitOfWork<C>(contextFactory))
        {
            ContextFactory = contextFactory;
            this.dbset = Context.Set<T>();
        }

        public BaseRepository(IUnitOfWork unitOfWork, IContextFactory<C> contextFactory)
            : base(new BaseUnitOfWork<C>(contextFactory))
        {
            if (unitOfWork == null) throw new ArgumentNullException("unitOfWork");
            ContextFactory = contextFactory;
            //this.UnitOfWork = contextFactory; iunit needs to be in icontext for this to work.
            //this.UnitOfWork = unitOfWork;
            this.dbset = Context.Set<T>();
        }

        protected virtual void SetEntityState(object entity, EntityState entityState)
        {
            this.Context.Entry(entity).State = entityState;
        }

        public virtual void Update(T item)
        {
            this.dbset.Attach(item);
            dbContext.Entry(item).State = EntityState.Modified;
            //this.Context.SaveChanges();
            this.UnitOfWork.Save();
        }
    }
}
