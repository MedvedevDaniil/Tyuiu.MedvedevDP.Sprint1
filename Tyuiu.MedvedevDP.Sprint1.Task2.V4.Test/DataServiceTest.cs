using Tyuiu.MedvedevDP.Sprint1.Task2.V4.Lib;

namespace Tyuiu.MedvedevDP.Sprint1.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService dataService = new DataService();
            int x = 2;
            var res = dataService.CalculateSquare(x);
            Assert.AreEqual(4, res);
        }
    }
}
