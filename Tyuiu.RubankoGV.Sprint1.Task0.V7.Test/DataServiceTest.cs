using Tyuiu.RubankoGV.Sprint1.Task0.V14.Lib;
namespace Tyuiu.RubankoGV.Sprint1.Task0.V7.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(25, res);
        }
    }
}