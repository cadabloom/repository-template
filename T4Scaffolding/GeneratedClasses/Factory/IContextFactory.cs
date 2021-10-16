using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BR.Core.Data.SqlServer.Factory
{
    public interface IContextFactory
    {
        BRDBContext Get();
    }
}
