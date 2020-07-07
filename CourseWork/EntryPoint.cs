using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Drawing;

namespace CourseWork
{

    class EntryPoint
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/maps");
            driver.Manage().Window.Maximize();
            GoogleMainPage googleMapsInit = new GoogleMainPage(driver);
            googleMapsInit.StartMap();
            var moves = new Moves(driver);
            moves.MoveToCoordinate(new ListCoordinates().GetCollectionCoordinates(new File().ReadFile()));
        }
    }
}
