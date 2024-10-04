using Tyuiu.RubankoGV.Sprint1.Task7.V10.Lib;
namespace Tyuiu.RubankoGV.Sprint1.Task7.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Рубанко Г.В. | ИБКСб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* спринт #1                                                               *");
            Console.WriteLine("* Тема : Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Рубанко Геннадий Вячеславович | ИБКСб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x;


            Console.WriteLine("Введите переменную x");
            x = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine(ds.Calculate(x));

            Console.ReadLine();
        }
    }
}
