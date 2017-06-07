using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPTests
{
    public class LoginPage
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

        private int PAGE_LOAD_TIMEOUT = 10;
        public bool IsAt()
        {
            By element = By.Id("login_error");
            return Browser.WaitUntilElementDisplayed(element, PAGE_LOAD_TIMEOUT);
        }
    }
}
