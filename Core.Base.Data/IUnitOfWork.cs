using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Base.Data
{
    public interface IUnitOfWork
    {
        void Save();
    }
}
