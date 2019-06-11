using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Actions
{
    class SaveVariable
    {
        public static string On(IWebDriver driver, By locator)
        {
           return  driver.FindElement(locator).Text;
        }
    }
}
