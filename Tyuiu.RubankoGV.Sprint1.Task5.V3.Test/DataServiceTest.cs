using Tyuiu.RubankoGV.Sprint1.Task5.V3.Lib;
namespace Tyuiu.RubankoGV.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int h = 123456;
            int res = ds.Calculate(h);

            int result = Convert.ToInt32(res);
            int wait = 4;
            Assert.AreEqual(wait, result);



        }
    }
}