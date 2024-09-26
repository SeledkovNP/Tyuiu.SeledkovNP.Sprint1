using Tyuiu.SeledkovNP.Sprint1.Task2.V6.Lib;

namespace Tyuiu.SeledkovNP.Sprint1.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

          DataService ds = new DataService();
            double x = 2.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
            

        }
    }
}