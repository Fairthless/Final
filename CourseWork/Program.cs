using System;
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
            googleMapsInit.ClickSatellite();
            googleMapsInit.ClickGlobeMod();
            googleMapsInit.ClickThirdDeminsion();
            googleMapsInit.Check();
            InputCoordinates inputCoordinates = new InputCoordinates();
            inputCoordinates.OpenFile();
            Moves moves = new Moves(driver);
            moves.KeyArrowDown();
        }
    }
}
