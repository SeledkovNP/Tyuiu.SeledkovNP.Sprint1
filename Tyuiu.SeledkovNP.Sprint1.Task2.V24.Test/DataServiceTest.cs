using Tyuiu.SeledkovNP.Sprint1.Task2.V24.Lib;
namespace Tyuiu.SeledkovNP.Sprint1.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
         

            DataService ds = new DataService();
            int x = 4;
            int y = 2;
            var res = ds.CalculateDiffSquare(x, y);
            Assert.AreEqual(4, res);


        }
    }
}