using Tyuiu.RubankoGV.Sprint1.Task3.V15.Lib;
namespace Tyuiu.RubankoGV.Sprint1.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Рубанко Г. В. | ИБКСБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Рубанко Г. В. | ИБКСБ-24-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, решающую следующую задачу: два автомобиля имеют     *");
            Console.WriteLine("* скорости V1 км/ч и V2 км/ч соответственно, находятся на расстоянии S км *");
            Console.WriteLine("* друг от друга и движутся в противоположные стороны. Определить          *");
            Console.WriteLine("* расстояние между ними через T часов.                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double v1, v2, S, T;
            Console.WriteLine("Введите скорость первого автомобиля:");
            v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите скорость второго автомобиля::");
            v2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите первоначальное расстояние между автомобилями:");
            S = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите время:");
            T = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Расстояние = " + ds.DistanceOverTime(v1, v2, S, T));

            Console.ReadLine();
        }
    }
}
