using Tyuiu.RubankoGV.Sprint1.Task6.V9.Lib;
namespace Tyuiu.RubankoGV.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string wrds = "100 1000";
            DataService ds = new DataService();
            string res = ds.MoveLetterToStart(wrds);
            string itg = "010 0100";
            Assert.AreEqual(itg, res);
        }
    }
}