using Tyuiu.SeledkovNP.Sprint1.Task3.V3.Lib;

namespace Tyuiu.SeledkovNP.Sprint1.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            double length = 2;
            double width = 3;
            double height = 4;
            double wait = 24;
            var res = ds.ParallelepipedVolume(length, width, height);
            Assert.AreEqual(wait, res);
            
        }
    }
}