using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SIPTests
{
    [TestClass]
    public class TC12_NewRouteSuccessfullyEdited : TestBase
    {
        [TestMethod]
        public void RunTest_TC12()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.Route();
            Assert.IsTrue(Pages.Route.IsAt(), "The user can't access Route page.");
            
            Pages.AddRoute.EditRoute("AutoTestRoute01");
            Pages.AddRoute.ConfirmEdit();

        }
    }
}



