using Tyuiu.KhrapkoDD.Sprint1.Task5.V6.Lib;

namespace Tyuiu.KhrapkoDD.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, DataService.GetDayOfWeek(1)); // �����������
            Assert.AreEqual(2, DataService.GetDayOfWeek(2)); // �������
            Assert.AreEqual(3, DataService.GetDayOfWeek(3)); // �����
            Assert.AreEqual(4, DataService.GetDayOfWeek(4)); // �������
            Assert.AreEqual(5, DataService.GetDayOfWeek(5)); // �������
            Assert.AreEqual(6, DataService.GetDayOfWeek(6)); // �������
            Assert.AreEqual(7, DataService.GetDayOfWeek(7)); // �����������
            Assert.AreEqual(1, DataService.GetDayOfWeek(8)); // �����������
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => DataService.GetDayOfWeek(0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => DataService.GetDayOfWeek(366));
        }
    }
}