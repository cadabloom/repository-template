using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using BR.Core.Data.SqlServer.Configuration;

namespace BR.Core.Data.SqlServer
{
	public class BRDBContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public virtual void Save()
        {
            base.SaveChanges();
        }
    }
}

