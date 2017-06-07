using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPTests
{
    public class AddNewUserPage : Browser 
    {
        private static int PAGE_LOAD_TIMEOUT = 10;

        public bool IsAt()
        {
            By element = By.XPath("//a[contains(text(),'Add User')]");
            return Browser.WaitUntilElementDisplayed(element, PAGE_LOAD_TIMEOUT);

        }
        public bool UsergroupIsVisible()
        {
            By element = By.XPath("//a[contains(text(),'Supervisor')]");
            return Browser.WaitUntilElementDisplayed(element, PAGE_LOAD_TIMEOUT);

        }

        public void AddUser(string name, string position, string email, string address, string username, string usergroupName, string password, string gender, string contactNumber, string dob, string confirmPassword)
        {
            var uploadPic = Driver.FindElement(By.Id("addProfileImg"));
            uploadPic.SendKeys(@"C:\library\kam.PNG");

            var nameField = Driver.FindElement(By.Id("name"));
            nameField.SendKeys(name);

            var positionField = Driver.FindElement(By.Id("position"));
            positionField.SendKeys(position);

            var emailField = Driver.FindElement(By.Id("email"));
            emailField.SendKeys(email);

            var addressField = Driver.FindElement(By.Id("address"));
            addressField.SendKeys(address);

            var usernameField = Driver.FindElement(By.Id("username"));
            usernameField.SendKeys(username);

            var userGroup = Driver.FindElement(By.Id("usergroup"));
            userGroup.Click();
            userGroup.SendKeys(usergroupName);
            userGroup.Click();
            
            var passwordField = Driver.FindElement(By.Id("password"));
            passwordField.SendKeys(password);
            
            var genderField = Driver.FindElement(By.Id("gender"));
            genderField.Click();
            genderField.SendKeys(gender);
            genderField.Click();
            
            var contactNumberField = Driver.FindElement(By.Id("contactNumber"));
            contactNumberField.SendKeys(contactNumber);

            var dobField = Driver.FindElement(By.Id("dob"));
            dobField.SendKeys(dob);
            dobField.Click();

            var confirmPasswordField = Driver.FindElement(By.Id("confirmPassword"));
            confirmPasswordField.SendKeys(confirmPassword);

        }
    }
}
