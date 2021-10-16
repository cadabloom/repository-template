using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BR.Core.Model;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;

namespace BR.Core.Data.SqlServer.Configuration
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
            : base()
        {
        }
    }
}