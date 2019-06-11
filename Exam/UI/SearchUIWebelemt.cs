using Exam.Tests;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exam.UI
{
    class SearchUIWebelemt : BaseTest
    {
        public static IWebElement OrderPriceASC = Driver.FindElement(By.XPath("//div[@class = 'srp-controls--selected-value'][text() = 'Mejor resultado']"));
        public static Regex regExtpToPrice = new Regex("\\$[\\d .]*"); 

    }
}
