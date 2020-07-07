
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Threading;

namespace CourseWork
{
    public class Moves
    {
        IWebDriver _driver;
        By _searchString = By.XPath("//input[@autofocus='autofocus']");
        By _searchButton = By.XPath("//button[@guidedhelpid='searchbutton']");
        By _check = By.XPath("//div[@role='main']");
        public Moves(IWebDriver driver)
        {
            _driver = driver;
        }
        public void MoveToCoordinate(List<string> listOfCoordinates)
        {
            WebDriverWait wait = new WebDriverWait(_driver, System.TimeSpan.FromSeconds(15));
            IWebElement SearchString = wait.Until(ExpectedConditions.ElementToBeClickable(_searchString));
            IWebElement searchButton = wait.Until(ExpectedConditions.ElementToBeClickable(_searchButton));

            foreach (var coord in listOfCoordinates)
            {
                SearchString.Clear();
                SearchString.SendKeys(coord);
                searchButton.Click();
                IWebElement check = wait.Until(ExpectedConditions.ElementToBeClickable(_check));
                check.Click();
                new GoogleMainPage(_driver).ClickThirdDeminsion();
                Thread.Sleep(7000);
            }
        }

    }
}
