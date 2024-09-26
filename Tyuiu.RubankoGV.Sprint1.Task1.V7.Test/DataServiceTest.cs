using Tyuiu.RubankoGV.Sprint1.Task1.V7.Lib;
namespace Tyuiu.RubankoGV.Sprint1.Task1.V7.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void ValidExpressions()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 4.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}