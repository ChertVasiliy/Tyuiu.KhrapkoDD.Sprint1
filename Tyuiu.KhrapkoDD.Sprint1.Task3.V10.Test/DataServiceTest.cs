using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using Tyuiu.KhrapkoDD.Sprint1.Task3.V10.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.KhrapkoDD.Sprint1.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double number = 23.4;

            var rest = ds.Convert(number);
            Assert.AreEqual($"ответ 23 руб. 40 коп.", rest);
        }
    }
}
