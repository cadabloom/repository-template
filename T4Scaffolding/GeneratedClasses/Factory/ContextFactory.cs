using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Base.Data.SqlServer;

namespace BR.Core.Data.SqlServer.Factory
{
    public class ContextFactory : Disposable, IContextFactory
    {
        private BRDBContext dataContext;
        public BRDBContext Get()
        {
            return dataContext ?? (dataContext = new BRDBContext());
        }

        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}