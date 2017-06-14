using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPTests
{
    public class AddPOIPage : Browser
    {
        internal void AddNewPOI(string poiName, string poiType, string poiOperationHours)
        {
            var poiname = Driver.FindElement(By.Id("poiName"));
            poiname.SendKeys(poiName);

            var poitype = Driver.FindElement(By.Id("poiType"));
            poitype.SendKeys(poiType);

            var poiOperation = Driver.FindElement(By.Id("poiOperationHours"));
            poiOperation.SendKeys(poiOperationHours);

            var markerType = Driver.FindElement(By.Id("fontAwesome"));
            markerType.Click();


        }

        internal void Confirm()
        {

            var confirmAddPOI = Driver.FindElement(By.Id("submitBtn"));
            confirmAddPOI.Click();
        }

        private static int PAGE_LOAD_TIMEOUT = 10;

        public bool IsAt()
        {
            By element = By.XPath("//label[contains(text(),'Add POI')]");
            return WaitUntilElementDisplayed(element, PAGE_LOAD_TIMEOUT);
        }
    }
}
