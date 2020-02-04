using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace CourseWork
{
    public class GoogleMapsInit
    {
        By satellite = By.CssSelector("button[vet='27742']");
        By globeMod = By.CssSelector("button[aria-label='Включение режима глобуса Уменьшите масштаб и рассмотрите планету в режиме 3D']");
        By thirdDMod = By.CssSelector("button[aria-label='Изменить угол обзора']");
        private IWebDriver driver;
       
        public GoogleMapsInit(IWebDriver driver) => this.driver = driver;
      
        public void check()
        {
      //     Dictionary<string, int> pa = new Dictionary<string, int>();
        //    pa.Add("12", 23);
          //  Console.WriteLine(pa.Count);
        }
        public void clickSatellite()
        {
            findElem(satellite);    
            driver.FindElement(satellite).Click();
        }
        public void clickGlobeMod()
        { 
        driver.FindElement(globeMod).Click();
        }
        public void clickThirdDeminsion()
        {
            findElem(thirdDMod);
            driver.FindElement(thirdDMod).Click();
                
                }
        public void  findElem(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
          IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }
       
    }

}
