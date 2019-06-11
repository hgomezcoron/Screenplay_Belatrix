using Exam.Tests;
using Exam.UI;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Tasks
{
    [TestFixture]
    public class EbayTestSuite : BaseTest
    {
        [Test]
        [NUnit.Framework.Description("Search in Ebay")]
        public void SearchItem()
        {
            const string NAME_EXPECTED = "!! rara!!! Alexander Mcqueen para Puma Zapatillas De Hombre Talla 10US congac Joust Piel de PotroCOP $2 186 274.51  0 ofertas de subasta+COP $203 594.77 por el envíoMarcar como favorito";
            //Search Item
            Search.As(Driver, "shoes", "PUMA");
            //Get and print 
            string text =Search.Save(Driver);
            Console.WriteLine("TOTAL NUMBER ITEMS: ", text);
            //Order by price ASC
            Search.OrderPrice(Driver);
            //Aseerts 5 items
            Search.Assert1(Driver);
            Search.Assert2(Driver);
            Search.Assert3(Driver);
            Search.Assert4(Driver);
            Search.Assert5(Driver);
            var list = Search.OrderDataTake5();
            var list2 = Search.OrderDataByName();
            var list3 = Search.OrderDataByPrice();
            Assert.AreEqual(5, Search.OrderDataTake5());
            Assert.AreEqual(NAME_EXPECTED, list2);
            Assert.AreEqual(2614346.41M, Search.OrderDataByPrice());

        }
    }
}
