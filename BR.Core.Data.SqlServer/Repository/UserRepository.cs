using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BR.Core.Data.Model;
using Core.Base.Data.SqlServer;
using Core.Base.Data.SqlServer.Repository;
using Core.Base.Data.SqlServer.Factory;

namespace BR.Core.Data.SqlServer.Repository
{
	public class UserRepository : BaseRepository<User, BRDBContext>, IUserRepository 
	{
		public UserRepository(IContextFactory<BRDBContext> contextFactory) :
            base(new BaseUnitOfWork<BRDBContext>(contextFactory), contextFactory)
        {
        }

	}
}

