using Tyuiu.KhrapkoDD.Sprint1.Task6.V1.Lib;

namespace Tyuiu.KhrapkoDD.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSymbolCode()
        {
            // Arrang
            char symbol = '1';
            int expectedCode = 49;

            // Act
            int actualCode = DataService.SymbolCode(symbol);

            // Assert
            Assert.AreEqual(expectedCode, actualCode);
        }
    }
}