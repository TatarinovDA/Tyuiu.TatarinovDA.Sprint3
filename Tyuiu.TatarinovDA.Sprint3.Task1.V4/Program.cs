using Tyuiu.TatarinovDA.Sprint3.Task1.V4.Lib;
//Написать программу используя цикл while, которая вычисляет сумму ряда по формуле
//

namespace Tyuiu.TatarinovDA.Sprint3.Task1.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Татаринов Д. А. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Татаринов Данил Андреевич | ИСТНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет              *");
            Console.WriteLine("* сумму ряда по формуле                                                   *");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            int startValue = 1;
            int stopValue = 10;
            Console.WriteLine($"* Начальное значение k: {startValue}");
            Console.WriteLine($"* Конечное значение k: {stopValue}");




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetSumSeries(startValue, stopValue);
            Console.WriteLine($"* Сумма ряда = {Math.Round(result,4)}");



            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }

}
