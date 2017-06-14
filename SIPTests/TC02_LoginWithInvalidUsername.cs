using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SIPTests
{
    [TestClass]
    public class TC02_LoginWithInvalidUsername : TestBase
    {
        [TestMethod]
        public void RunTest_TC02()
        {
            Pages.Login.Goto();
            Pages.Login.Login("invalidusername", "admin");
            Assert.IsTrue(Pages.Loginpage.IsAt(), "Where is the error message?");

            Pages.Login.TakeScreenShot();
            
        }
    }
}
