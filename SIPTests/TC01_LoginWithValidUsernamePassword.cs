using System;
using SIPTestFramework;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SIPTests
{
    [TestClass]
    public class TC01_LoginWithValidUsernamePassword : TestBase
    {
        [TestMethod]
        public void RunTest_TC01()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.LogOut();
            
        }
    }
}
