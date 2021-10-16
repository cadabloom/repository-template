using System;
using BR.Core.Data;
using BR.Core.Data.SqlServer.Repository;
using Core.Base.Data.SqlServer.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreDataTierTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_UserRepo_Get_All()
        {
            IUserRepository _userRepository = new UserRepository(new BaseContextFactory<BR.Core.Data.SqlServer.BRDBContext>());
            var test = _userRepository.GetAll();
        }
    }
}
