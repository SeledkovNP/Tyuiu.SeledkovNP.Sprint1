using Tyuiu.SeledkovNP.Sprint1.Task6.V15.Lib;
namespace Tyuiu.SeledkovNP.Sprint1.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCheckLettersCount()
        {
            DataService ds = new DataService();
            string value = "stroki ...";
            bool result = ds.CheckLettersCount(value);
            Assert.AreEqual(true, result);
        }
    }
}