using Tyuiu.RubankoGV.Sprint1.Task7.V10.Lib;
namespace Tyuiu.RubankoGV.Sprint1.Task7.V10.Test
{
    public class Tests
    {
        [SetUp]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double wait = 0.727;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}