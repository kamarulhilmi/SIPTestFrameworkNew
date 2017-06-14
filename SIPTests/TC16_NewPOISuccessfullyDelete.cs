using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SIPTests
{
    [TestClass]
    public class TC16_NewPOISuccessfullyDelete : TestBase
    {
        [TestMethod]
        public void RunTest_TC16()
        {
            Pages.Login.Goto();
            Pages.Login.Login("admin", "admin");
            Assert.IsTrue(Pages.MapDashboard.IsAt(), "The user can't access map dahsboard page.");

            Pages.MapDashboard.POIManagement();
            Assert.IsTrue(Pages.POIManagement.IsAt(), "The user can't access POI Management page.");

            Pages.POIManagement.DeletePOI("AutoTestPOI");
            Pages.POIManagement.ConfirmDelete();

        }
    }
}



