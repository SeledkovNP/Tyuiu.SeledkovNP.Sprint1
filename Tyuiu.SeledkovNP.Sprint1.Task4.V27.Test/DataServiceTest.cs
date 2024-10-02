using Tyuiu.SeledkovNP.Sprint1.Task4.V27.Lib;

namespace Tyuiu.SeledkovNP.Sprint1.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            double x = 3;
            double y = 4;
            double wait = 1;
            var res = ds.Calculate(x, y);           // 1 + (Math.Sin(x * Math.PI)) / (x - Math.Sqrt(Math.Abs(y)));    1+(sin(x*3.14) / (x - корен Полж (у)
            Assert.AreEqual(wait, res);               // 1 / 3 - 2            

        }
    }
}