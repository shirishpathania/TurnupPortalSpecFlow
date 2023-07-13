using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnupPortalSpecFlow.Pages;
using TurnupPortalSpecFlow.Utilities;

namespace TurnupPortalSpecFlow.StepDefinitions
{
    [Binding]
    public class TMStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        LoginPage loginPageObject = new LoginPage();
        HomePage homePageObject = new HomePage();
        TM_Page tmPageObject = new TM_Page();

        [Given(@"I log into Turnup portal")]
        public void GivenILogIntoTurnupPortal()
        {
            loginPageObject.LoginSteps(driver);

        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            homePageObject.GoToTMPage(driver);
        }

        [When(@"I create a new Time and Material record '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenICreateANewTimeAndMaterialRecord(String code, String description, String price)
        {
            tmPageObject.CreateTimeRecord(driver, code, description, price);

        }

        [Then(@"the record should be saved '([^']*)'")]
        public void ThenTheRecordShouldBeSaved(String code)
        {
            tmPageObject.AssertCreateTimeRecord(driver, code);
            driver.Quit();
        }

        [When(@"I edit an existing Time and Material record '([^']*)' '([^']*)'")]
        public void WhenIEditANewTimeAndMaterialRecord(string oldCode, String newCode)
        {
            tmPageObject.EditTimeRecord(driver, oldCode, newCode);
        }

        [Then(@"the record should be updated '([^']*)'")]
        public void ThenTheRecordShouldBeUpdated(string newCode)
        {
            tmPageObject.AssertEditTimeRecord(driver, newCode);
            driver.Quit();
        }

        [When(@"I delete an existing Time and Material record '([^']*)'")]
        public void WhenIDeleteAnExistingTimeAndMaterialRecord(string code)
        {
            tmPageObject.DeleteTimeRecord(driver, code);
        }

        [Then(@"the record should be deleted '([^']*)'")]
        public void ThenTheRecordShouldBeDeleted(string code)
        {
            tmPageObject.AssertDeleteTimeRecord(driver, code);
            driver.Quit();
        }
    }
}
