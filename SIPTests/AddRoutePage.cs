using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA;
using OpenQA.Selenium;

namespace SIPTests
{
    public class AddRoutePage : Browser
    {
        internal void AddNewRoute(string routeName)
        {
            var routename = Driver.FindElement(By.Id("routename"));
            routename.SendKeys(routeName);
            
        }

        internal void Confirm()
        {
            var confirmButton = Driver.FindElement(By.Id("btnSubmitRoute"));
            confirmButton.Click();
        }
    }
}
