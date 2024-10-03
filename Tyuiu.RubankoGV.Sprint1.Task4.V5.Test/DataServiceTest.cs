using Tyuiu.RubankoGV.Sprint1.Task4.V5.Lib;
namespace Tyuiu.RubankoGV.Sprint1.Task4.V5.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = 0.25;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}