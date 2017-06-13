using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SIPTests
{
    [TestClass]
    public class TC11_NewRouteSuccessfullyAdded  : TestBase
    {
        [TestMethod]
        public void RunTest_TC11()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.Route();
            Assert.IsTrue(Pages.Route.IsAt(), "The user can't access Route page.");

            Pages.Route.AddRoute();
            Pages.AddRoute.AddNewRoute(
                "AutoTestRoute02", //route name
                "FF17E0");          //route color
            Pages.AddRoute.Confirm();
            
        }
    }
}



