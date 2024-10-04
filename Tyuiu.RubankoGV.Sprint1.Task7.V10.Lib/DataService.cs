using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.RubankoGV.Sprint1.Task7.V10.Lib
{
    public class DataService : ISprint1Task7V10
    {
        public double Calculate(double x)
        {
            double res = 2 * (Math.Cos(3 * x) / Math.Sin(3 * x)) - (Math.Log10(Math.Cos(x)) / Math.Log10(1 + Math.Pow(x, 2)));
            double res1 = (Math.Round(res * 1000) / 1000);
            return res1;
        }
    }
}
