using Tyuiu.RubankoGV.Sprint1.Task3.V15.Lib;
namespace Tyuiu.RubankoGV.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double v1 = 2;
            double v2 = 3;
            double S = 25;
            double T = 5;
            var res = ds.DistanceOverTime(v1, v2, S, T);
            Assert.AreEqual(50, res);
        }
    }
}