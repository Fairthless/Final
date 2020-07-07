using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CourseWork
{
    public class GoogleMainPage
    {
        By satellite = By.XPath("//button[@aria-labelledby='widget-minimap-caption']");
        By globeMod = By.XPath("//button[@aria-checked='false']");
        By thirdDMod = By.XPath("//button[@class='widget-tilt-button']");
        private IWebDriver driver;

        public GoogleMainPage(IWebDriver driver) => this.driver = driver;
        private void ClickSatellite()
        {
            findElementToBeClickable(satellite);
            driver.FindElement(satellite).Click();
        }
        private void ClickGlobeMod() => driver.FindElement(globeMod).Click();

        public void ClickThirdDeminsion()
        {
            findElementToBeClickable(thirdDMod);
            driver.FindElement(thirdDMod).Click();

        }
        private void findElementToBeClickable(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public void StartMap()
        {
            ClickSatellite();
            ClickGlobeMod();
            ClickThirdDeminsion();
        }
    }
}
