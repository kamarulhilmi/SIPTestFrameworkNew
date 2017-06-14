using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SIPTests
{
    [TestClass]
    public class TC03_LoginWithInvalidPassword : TestBase
    {
        [TestMethod]
        public void RunTest_TC03()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "test");
            Assert.IsTrue(Pages.Loginpage.IsAt(), "Error message?");

            Pages.Login.TakeScreenShot();
            
        }
    }
}
