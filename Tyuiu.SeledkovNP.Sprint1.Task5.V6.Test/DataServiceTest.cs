using Tyuiu.SeledkovNP.Sprint1.Task5.V6.Lib;
namespace Tyuiu.SeledkovNP.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            var dataService = new DataService();
            Assert.AreEqual(29, dataService.Calculate(7));

        }
    }
}