using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnupPortalSpecFlow.Utilities;

namespace TurnupPortalSpecFlow.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            // Navigate to time and material page
            IWebElement administrationTab = driver.FindElement(By.XPath("//a[contains(text(),'Administration')]"));
            administrationTab.Click();
            
            // Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 7); Absolute XPath
            Wait.WaitToBeClickable(driver, "XPath", "//a[contains(text(),'Administration')]", 7); // Relative XPath

            IWebElement tmOption = driver.FindElement(By.XPath("//a[contains(text(),'Time & Materials')]"));
            tmOption.Click();
        }

        public void GoToEmployeesPage()
        {
            // Code that navigates to Employee page
        }
    }
}
