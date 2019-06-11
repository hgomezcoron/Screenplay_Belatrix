using Exam.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.UI
{
    class SearchUI
    {
        public static By UserInput = By.Id("gh-ac");
        public static By SearchButton = By.Id("gh-btn");
        public static By FieldSearchBranch = By.Id("w3-w12-0[0]");
        public static By BranchPuma = By.XPath("//li[@class = 'x-refine__main__list x-refine__main__list--aspect']//input[@aria-label = 'PUMA']");
        public static By Size = By.XPath("//li[@class = 'x-refine__main__list x-refine__main__list--aspect']//input[@aria-label = '10']");
        public static By Number = By.XPath("//h1[@class = 'srp-controls__count-heading']");
        //Order price ASC
        public static By TextOrderPriceASC = By.XPath("//ul[@class = 'srp-sort__menu']//span[text() = 'Precio + Envío: más alto primero']");
        //Aseert 5 items
        public static By Item1 = By.XPath("//h3[@class = 's-item__title'][text() = 'Puma Clyde X WWE \"dinero en el banco\" Colección maletín Limitada US talla 10 para hombre']");
        public static By Item2 = By.XPath("//h3[@class = 's-item__title'][text() = 'Puma Clyde X WWE dinero en el Bank Oro tenis zapatos Limited 100 pares nuevo 10']");
        public static By Item3 = By.XPath("//h3[@class = 's-item__title'][text() = '2009 PUMA UNDFTD 24K Mediados de oro metálico blanco Undefeated 349567-01 nuevo 10']");
        public static By Item4 = By.XPath("//h3[@class = 's-item__title'][text() = 'Zapatos De Cuero rara VINTAGE PUMA especial 657, Alemania del Oeste, Azul Talla 10, NUEVO!!!']");
        public static By Item5 = By.XPath("//h3[@class = 's-item__title'][text() = '!! rara!!! Alexander Mcqueen para Puma Zapatillas De Hombre Talla 10US congac Joust Piel de Potro']");
    }
}
