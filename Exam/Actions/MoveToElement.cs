using OpenQA.Selenium;
using Act= OpenQA.Selenium.Interactions;

namespace Exam.Actions
{
    class MoveToElement
    {
        public static void To(IWebDriver driver, IWebElement locator)
        {
            Act.Actions _action = new Act.Actions(driver);
            _action.MoveToElement(locator).Perform();
        }
    }
}
