using Tyuiu.MedvedevDP.Sprint1.Task4.V6.Lib;

namespace Tyuiu.MedvedevDP.Sprint1.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService dataService = new DataService();

            double x = 2;
            double y = 3;
            double wait = 1.167;
            var res = dataService.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
