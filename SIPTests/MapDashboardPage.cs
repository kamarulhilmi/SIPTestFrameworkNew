using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPTests
{
    public class MapDashboardPage : Browser
    {
        private static int PAGE_LOAD_TIMEOUT = 10;

        public bool IsAt()
        {
            By element = By.XPath("//a[contains(text(),'Home')]");
            return WaitUntilElementDisplayed(element, PAGE_LOAD_TIMEOUT);

        }

        public bool IsUserMngtDisplay()
        {
            By element = By.XPath("//a[contains(text(),'User Management')]");
            return WaitUntilElementDisplayed(element, PAGE_LOAD_TIMEOUT);
        }
        public bool IsUserGroupDisplay()
        {
            By element = By.XPath("//a[contains(text(),'User Group')]");
            return WaitUntilElementDisplayed(element, PAGE_LOAD_TIMEOUT);
        }

        internal void LogOut()
        {
            var logoutButton1 = Driver.FindElement(By.Id("menu2"));
            logoutButton1.Click();
            var logoutButton2 = Driver.FindElement(By.Id("logout"));
            logoutButton2.Click();
        }
        
        public bool IsElementPresent(By by)
        {
            try
            {
                Driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void UserManagement()
        {
            var menu = Driver.FindElement(By.Id("menu1"));
            var subMenu = Driver.FindElement(By.XPath("//a[contains(text(),'User')]"));
            var userManagement = Driver.FindElement(By.XPath("//a[contains(text(),'User Management')]"));
            Actions action = new Actions(webDriver);

            menu.Click();
            action.MoveToElement(subMenu).Build().Perform();
            action.MoveToElement(userManagement).Build().Perform();
            
            do
            {
                if (IsElementPresent(By.XPath("//a[contains(text(),'User Management')]")))
                {
                    try
                    {
                        Assert.IsTrue(Pages.MapDashboard.IsUserMngtDisplay(), "The user management element is not display");
                        userManagement.Click();
                        break;
                    }
                    catch (Exception)
                    {
                        action.MoveToElement(subMenu).Build().Perform();
                        action.MoveToElement(userManagement).Build().Perform();
                    }
                }
            }
            while (true);
        }
        

        public void UserGroup()
        {
            var menu = Driver.FindElement(By.Id("menu1"));
            var subMenu = Driver.FindElement(By.XPath("//a[contains(text(),'User')]"));
            var userGroup = Driver.FindElement(By.XPath("//a[contains(text(),'User Group')]"));
            Actions action = new Actions(webDriver);

            menu.Click();
            action.MoveToElement(subMenu).Build().Perform();
            action.MoveToElement(userGroup).Build().Perform();

            do
            {
                if (IsElementPresent(By.XPath("//a[contains(text(),'User Group')]")))
                {
                    try
                    {
                        Assert.IsTrue(Pages.MapDashboard.IsUserGroupDisplay(), "The user management element is not display");
                        userGroup.Click();
                        break;
                    }
                    catch (Exception)
                    {
                        action.MoveToElement(subMenu).Build().Perform();
                        action.MoveToElement(userGroup).Build().Perform();
                    }
                }

            } while (true);
        }

       
    }

}
