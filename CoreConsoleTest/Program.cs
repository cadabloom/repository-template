using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR.Core.Data;
using BR.Core.Data.SqlServer.Repository;

namespace CoreConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserRepository _userRepository = new UserRepository(new Core.Base.Data.SqlServer.Factory.BaseContextFactory<BR.Core.Data.SqlServer.BRDBContext>());
            var test = _userRepository.GetAll();
        }
    }
}
