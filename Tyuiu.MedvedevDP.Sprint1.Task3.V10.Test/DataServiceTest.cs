using Tyuiu.MedvedevDP.Sprint1.Task3.V10.Lib;
namespace Tyuiu.MedvedevDP.Sprint1.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService dataService = new DataService();

            var x = 2.2;

            var res = dataService.NumberToMoney(x);

            Assert.AreEqual("2 рублей 2 копеек", res);
        }
    }
}
