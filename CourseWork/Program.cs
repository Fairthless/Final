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
    
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/maps");
            driver.Manage().Window.Maximize();
            GoogleMapsInit googleMapsInit = new GoogleMapsInit(driver);
            googleMapsInit.clickSatellite();
            googleMapsInit.clickGlobeMod();
            googleMapsInit.clickThirdDeminsion();
            googleMapsInit.check();
            Moves moves = new Moves(driver);
        }
    }
}
