using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BR.Core.Data.Model;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;

namespace BR.Core.Data.SqlServer.Configuration
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
            : base()
        {
            ToTable("Users", "dbo");
            HasKey(user => user.UserID);
        }
    }
}