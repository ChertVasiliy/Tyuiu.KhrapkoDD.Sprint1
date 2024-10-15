using System.Xml.XPath;
using Tyuiu.KhrapkoDD.Sprint1.Task7.V18.Lib;

namespace Tyuiu.KhrapkoDD.Sprint1.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService expression = new DataService();

            Assert.AreEqual(0.5, expression.Calculate(0, 0), 0.001);
            Assert.AreEqual(0.913, expression.Calculate(1, 1), 0.001);
            Assert.AreEqual(0.418, expression.Calculate(2, 2), 0.001);
        }
    }
}