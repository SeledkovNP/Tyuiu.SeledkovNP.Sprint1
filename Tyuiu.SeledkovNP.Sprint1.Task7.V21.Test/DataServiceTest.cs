using Tyuiu.SeledkovNP.Sprint1.Task7.V21.Lib;
namespace Tyuiu.SeledkovNP.Sprint1.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            double wait = ds.Calculate(1, 1);
            Assert.AreEqual(-2.314, wait, 0.001);


        }
    }
}