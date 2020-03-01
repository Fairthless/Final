
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Windows.Input;

namespace CourseWork
{
   public class Moves
    {
        private IWebDriver _driver;
        private Actions _actions;
      public Moves(IWebDriver driver) => this._driver = _driver;

        public void KeyArrowDown()
        {

          //  if (Keyboard.IsKeyDown(Key.Down))
                _actions.KeyDown(Keys.ArrowDown);

        }
    }
}
