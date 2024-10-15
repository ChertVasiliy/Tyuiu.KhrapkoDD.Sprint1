using Tyuiu.KhrapkoDD.Sprint1.Task2.V15.Lib;
namespace Tyuiu.KhrapkoDD.Sprint1.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            var res = ds.ConvertHourToMin(x);
            Assert.AreEqual(1, res);
        }
    }
}