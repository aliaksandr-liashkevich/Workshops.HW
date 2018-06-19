using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW.Tests
{
    [TestClass]
    public class PriceCalculatorTest
    {
        public TestContext TestContext { get; set; }

        [DeploymentItem("Files\\PriceCalculator.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "PriceCalculator",
            "CalculatePrice",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void CalculatePrice_()
        {
            // arrange
            decimal price = Convert.ToDecimal(TestContext.DataRow["price"]);
            int age = Convert.ToInt32(TestContext.DataRow["age"]);
            PriceCalculator priceCalculator = new PriceCalculator(price);
            decimal expected = Convert.ToDecimal(TestContext.DataRow["expected"]);

            // act
            decimal actual = priceCalculator.CalculatePrice(age);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
