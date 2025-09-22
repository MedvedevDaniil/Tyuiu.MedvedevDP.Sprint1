using Tyuiu.MedvedevDP.Sprint1.Task7.V29.Lib;

namespace Tyuiu.MedvedevDP.Sprint1.Task7.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();

            double x = 1;
            double y = 2;

            double result = dataService.Calculate(x, y);

            Assert.AreEqual(1.661, result);
        }
    }
}
