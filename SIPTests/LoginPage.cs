using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SIPTests
{
    public class LoginPage : Browser
    {
        //method
        public void Goto()
        {
            Browser.Goto("/Account/Login");
        }

        public void Login(string username, string password)
        {
           
            var usernameField = Browser.Driver.FindElement(By.Id("input_user_name"));
            usernameField.SendKeys(username);

            var passwordField = Browser.Driver.FindElement(By.Id("input_password"));
            passwordField.SendKeys(password);

            Browser.Driver.FindElement(By.Id("btn_login")).Click();

        }

        internal void TakeScreenShot()
        {
            ITakesScreenshot screenshotDriver = Driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            string fp = "D:\\" + "snapshot" + "_" + DateTime.Now.ToString("dd_MMMM_hh_mm_ss_tt") + ".png";
            screenshot.SaveAsFile(fp, ScreenshotImageFormat.Png);
            
        }

        private int PAGE_LOAD_TIMEOUT = 10;
        public bool IsAt()
        {
            By element = By.Id("login_error");
            return Browser.WaitUntilElementDisplayed(element, PAGE_LOAD_TIMEOUT);
        }
    }
}
