using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SIPTests
{
    public class UserManagementPage : Browser
    {
        private static int PAGE_LOAD_TIMEOUT = 10;
        public static string v = ".";

        public bool IsAt()
        {
            By element = By.XPath("//label[contains(text(),'User Management')]");
            return Browser.WaitUntilElementDisplayed(element, PAGE_LOAD_TIMEOUT);
        }

        internal void AddNewUser()
        {
            var addUserButtton = Driver.FindElement(By.XPath("//button[contains(text(),'Add User')]"));
            addUserButtton.Click();
        }

        internal void AddNewUserConfirm()
        {
            var logoutButton = Driver.FindElement(By.Id("menu2"));
            logoutButton.Click();
            logoutButton.Click();

            var profileImage = Driver.FindElement(By.Id("profileImage"));
            profileImage.Click();

            var buttonSubmit = Driver.FindElement(By.Id("btnSubmit"));
            buttonSubmit.Click();
        }

        public void EditUser(string editeduser)
        {
            //need to working with html table
            By locator = By.Id("tableData");
            var table = Driver.FindElement(locator);

            //collection of all row in the table
            IList<IWebElement> collectionOfRows = table.FindElements(By.XPath("//*[@id='tableData']/tbody/tr"));

            var columnCounter = 1;
            var columnIndex = 12;
            string DESIRED_VALUE = editeduser;

            //logic
            for (int tr = 0; tr < collectionOfRows.Count; tr++)
            {
                var row = collectionOfRows[tr];

                IList<IWebElement> allCellsInRow = row.FindElements(By.XPath("./*"));
                
                foreach (var cell in allCellsInRow)
                {
                    if (cell.Text == DESIRED_VALUE)
                    {
                        string desiredValueLocator = string.Format(".//*[@id='tableData']/tbody/tr[{0}]/td[{1}]/i[1]", tr + 1, columnIndex);
                        v = desiredValueLocator;
                    }
                    columnCounter++;
                }
            }
        }

        public void ConfirmEdit()
        {
            var editButton = Driver.FindElement(By.XPath(v));
            editButton.Click();
        }
        
        public void DeleteUser(string deleteUser)
        {
            //need to working with html table
            By locator = By.Id("tableData");
            var table = Driver.FindElement(locator);

            //collection of all row in the table
            IList<IWebElement> collectionOfRows = table.FindElements(By.XPath("//*[@id='tableData']/tbody/tr"));

            var columnCounter = 1;
            var columnIndex = 12;
            string DESIRED_VALUE = deleteUser;

            //logic
            for (int tr = 0; tr < collectionOfRows.Count; tr++)
            {
                var row = collectionOfRows[tr];

                IList<IWebElement> allCellsInRow = row.FindElements(By.XPath("./*"));
                foreach (var cell in allCellsInRow)
                {
                    if (cell.Text == DESIRED_VALUE)
                    {
                        string desiredValueLocator = string.Format(".//*[@id='tableData']/tbody/tr[{0}]/td[{1}]/i[3]", tr + 1, columnIndex);
                        v = desiredValueLocator;
                    }
                    columnCounter++;
                }
            }
        }

        public void ConfirmDelete()
        {
            var deleteButton = Driver.FindElement(By.XPath(v));
            deleteButton.Click();
            var toConfirmDelete = Driver.FindElement(By.XPath("//button[contains(text(),'Yes')]"));
            toConfirmDelete.Click();
        }

        internal void ResetPassword(string resetPassword)
        {
            //need to working with html table
            By locator = By.Id("tableData");
            var table = Driver.FindElement(locator);

            //collection of all row in the table
            IList<IWebElement> collectionOfRows = table.FindElements(By.XPath("//*[@id='tableData']/tbody/tr"));

            var columnCounter = 1;
            var columnIndex = 12;
            string DESIRED_VALUE = resetPassword;

            //logic
            for (int tr = 0; tr < collectionOfRows.Count; tr++)
            {
                var row = collectionOfRows[tr];

                IList<IWebElement> allCellsInRow = row.FindElements(By.XPath("./*"));
                foreach (var cell in allCellsInRow)
                {
                    if (cell.Text == DESIRED_VALUE)
                    {
                        string desiredValueLocator = string.Format(".//*[@id='tableData']/tbody/tr[{0}]/td[{1}]/i[2]", tr + 1, columnIndex);
                        v = desiredValueLocator;
                    }
                    columnCounter++;
                }
            }
        }

        public void ConfirmResetPassword()
        {
            var resetPasswordButton = Driver.FindElement(By.XPath(v));
            resetPasswordButton.Click();
        }
    }
}
