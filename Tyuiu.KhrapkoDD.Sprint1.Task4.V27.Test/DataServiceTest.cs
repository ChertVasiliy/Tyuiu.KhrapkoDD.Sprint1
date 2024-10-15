using Tyuiu.KhrapkoDD.Sprint1.Task4.V27.Lib;

namespace Tyuiu.KhrapkoDD.Sprint1.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
            {
                DataService ds = new DataService();
                double x = 2;
                double y = 2;
                double wait = 1.707;
                var res = ds.Calculate(x, y);
                Assert.AreEqual(wait, Math.Round(res, 3));
            }
        }
    }