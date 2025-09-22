using Tyuiu.MedvedevDP.Sprint1.Task6.V1.Lib;
namespace Tyuiu.MedvedevDP.Sprint1.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "1 * 2 * 3";
            DataService dataService = new DataService();

            string res = dataService.SymbolCode( strTest );
            string wait = "123";
            Assert.AreEqual( wait, res );
        }
    }
}
