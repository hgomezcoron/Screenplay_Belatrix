using Exam.Actions;
using Exam.Tests;
using Exam.UI;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exam.Tasks
{
    public class Search: BaseTest
    {
        public static void As(IWebDriver driver, string text, string branch)
        {
            Enter.Text(driver, SearchUI.UserInput, text);
            Click.On(driver, SearchUI.SearchButton);
            Enter.Text(driver, SearchUI.FieldSearchBranch, branch);
            Click.On(driver, SearchUI.BranchPuma);
            Click.On(driver, SearchUI.Size);
        }

        public static string Save(IWebDriver driver)
        {
            string text =SaveVariable.On(driver, SearchUI.Number);
            return text;
        }

        public static void OrderPrice(IWebDriver driver)
        {
            MoveToElement.To(driver, SearchUIWebelemt.OrderPriceASC);
            Click.On(driver, SearchUI.TextOrderPriceASC);
        }

        public static void Assert1(IWebDriver driver)
        {
            string text = SaveVariable.On(driver, SearchUI.Item1);
            Assert.AreEqual("Puma Clyde X WWE \"dinero en el banco\" Colección maletín Limitada US talla 10 para hombre", text);
        }

        public static void Assert2(IWebDriver driver)
        {
            string text = SaveVariable.On(driver, SearchUI.Item2);
            Assert.AreEqual("Puma Clyde X WWE dinero en el Bank Oro tenis zapatos Limited 100 pares nuevo 10", text);
        }

        public static void Assert3(IWebDriver driver)
        {
            string text = SaveVariable.On(driver, SearchUI.Item3);
            Assert.AreEqual("2009 PUMA UNDFTD 24K Mediados de oro metálico blanco Undefeated 349567-01 nuevo 10", text);
        }

        public static void Assert4(IWebDriver driver)
        {
            string text = SaveVariable.On(driver, SearchUI.Item4);
            Assert.AreEqual("Zapatos De Cuero rara VINTAGE PUMA especial 657, Alemania del Oeste, Azul Talla 10, NUEVO!!!", text);
        }

        public static void Assert5(IWebDriver driver)
        {
            string text = SaveVariable.On(driver, SearchUI.Item5);
            Assert.AreEqual("!! rara!!! Alexander Mcqueen para Puma Zapatillas De Hombre Talla 10US congac Joust Piel de Potro", text);
        }

        public static int OrderDataTake5()
        {
            IList<IWebElement> list = Driver.FindElements(By.XPath("//div[@class = 's-item__info clearfix']"));
            //take 5 items and print
            var firstFive = list.ToList().Take(5);
            return firstFive.Count();
        }
        public static string OrderDataByName()
        {

         IList<IWebElement> list = Driver.FindElements(By.XPath("//div[@class = 's-item__info clearfix']"));
        //take all items and order by name ASC and print
        var OrderByName = list.ToList().Select(t =>  t.Text.ToString()).OrderBy(t => t.ToString()).ToList();
            return OrderByName.FirstOrDefault().Replace("\r\n", "");
           
        }
        public static decimal OrderDataByPrice()
        {
             Regex regExtpToPrice = new Regex("\\$[\\d .]*");
            IList<IWebElement> list = Driver.FindElements(By.XPath("//div[@class = 's-item__info clearfix']"));
            //take all items and order by price and print
            var orderByPrice = list.ToList().Select(t => {
                var text = SearchUIWebelemt.regExtpToPrice.Match(t.Text).Value;
                return Convert.ToDecimal (text.Replace(" ", "").Replace("$", ""));
               }).OrderByDescending(it => it).ToList();
            return orderByPrice.FirstOrDefault();
        }
    }
}
