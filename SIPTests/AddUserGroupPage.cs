using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPTests
{
    public class AddUserGroupPage : Browser
    {
        private static int PAGE_LOAD_TIMEOUT = 10;

        public bool IsAt()
        {
            By element = By.XPath("//label[contains(text(),'Add User Group')]");
            return WaitUntilElementDisplayed(element, PAGE_LOAD_TIMEOUT);

        }

        internal void AddGroup(string groupname)
        {
            var groupName = Driver.FindElement(By.Id("groupName"));
            groupName.SendKeys(groupname);

            var AllModulesPermissions = Driver.FindElement(By.XPath("//label[contains(text(),'All Modules Permissions')]"));
            AllModulesPermissions.Click();

            var logoutButton = Driver.FindElement(By.Id("menu2"));
            logoutButton.Click();
            logoutButton.Click();

            var submitButton = Driver.FindElement(By.Id("btnSubmit"));
            submitButton.Click();
        }
    }
}
