using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPTests
{
    public class UserGroupPage : Browser
    {
        private static int PAGE_LOAD_TIMEOUT = 10;
        public static string v = ".";

        public bool IsAt()
        {
            By element = By.XPath("//label[contains(text(),'User Group')]");
            return WaitUntilElementDisplayed(element, PAGE_LOAD_TIMEOUT);

        }

        internal void AddUserGroup()
        {
            var AddUserGroupButton = Driver.FindElement(By.Id("btnAddUserGroup"));
            AddUserGroupButton.Click();
        }

        public void EditUserGroup(string editedgroup)
        {
            //need to working with html table
            By locator = By.Id("tableData");
            var table = Driver.FindElement(locator);

            //collection of all row in the table
            IList<IWebElement> collectionOfRows = table.FindElements(By.XPath("//*[@id='tableData']/tbody/tr"));

            var columnCounter = 1;
            var columnIndex = 4;
            string DESIRED_VALUE = editedgroup;

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


        public void DeleteUserGroup(string deletedGroup)
        {
            //need to working with html table
            By locator = By.Id("tableData");
            var table = Driver.FindElement(locator);

            //collection of all row in the table
            IList<IWebElement> collectionOfRows = table.FindElements(By.XPath("//*[@id='tableData']/tbody/tr"));

            var columnCounter = 1;
            var columnIndex = 4;
            string DESIRED_VALUE = deletedGroup;

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

        public void ConfirmDelete()
        {
            var deleteButton = Driver.FindElement(By.XPath(v));
            deleteButton.Click();
            var toConfirmDelete = Driver.FindElement(By.XPath("//button[contains(text(),'Yes')]"));
            toConfirmDelete.Click();
        }
    }
}
