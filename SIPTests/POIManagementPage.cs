using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPTests
{
    public class POIManagementPage : Browser
    {
        private static int PAGE_LOAD_TIMEOUT = 10;
        public static string v = ".";

        public bool IsAt()
        {
            By element = By.XPath("//label[contains(text(),'POI Management')]");
            return WaitUntilElementDisplayed(element, PAGE_LOAD_TIMEOUT);
        }

        internal void AddPOI()
        {
            var addpoi = Driver.FindElement(By.Id("btnAddPOI"));
            addpoi.Click();
        }

        internal void EditPOI(string poiname)
        {
            //need to working with html table
            By locator = By.Id("tableData");
            var table = Driver.FindElement(locator);

            //collection of all row in the table
            IList<IWebElement> collectionOfRows = table.FindElements(By.XPath("//*[@id='tableData']/tbody/tr"));

            var columnCounter = 1;
            var columnIndex = 11;
            string DESIRED_VALUE = poiname;

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
        internal void ConfirmEdit()
        {
            var editButton = Driver.FindElement(By.XPath(v));
            editButton.Click();
        }

        internal void DeletePOI(string poiname)
        {
            //need to working with html table
            By locator = By.Id("tableData");
            var table = Driver.FindElement(locator);

            //collection of all row in the table
            IList<IWebElement> collectionOfRows = table.FindElements(By.XPath("//*[@id='tableData']/tbody/tr"));

            var columnCounter = 1;
            var columnIndex = 11;
            string DESIRED_VALUE = poiname;

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

        internal void ConfirmDelete()
        {
            var deleteButton = Driver.FindElement(By.XPath(v));
            deleteButton.Click();
        }
    }
}
