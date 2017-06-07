using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SIPTests
{
    [TestClass]
    public class TC09_UserGroupSuccessfullyEdited : TestBase
    {
        [TestMethod]
        public void RunTest_TC09()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.UserGroup();
            Assert.IsTrue(Pages.UserGroup.IsAt(), "The user can't access User Group page.");

            Pages.UserGroup.EditUserGroup("AutomationTest01");
            Pages.UserGroup.ConfirmEdit();
            
        }
    }
}
