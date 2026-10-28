using Tyuiu.TatarinovDA.Sprint3.Task7.V30.Lib;
// 
namespace Tyuiu.TatarinovDA.Sprint3.Task7.V30
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
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Татаринов Данил Андреевич | ИСТНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine($"Диапазон: [{startValue}; {stopValue}]");
            Console.WriteLine($"Шаг: 1");



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double[] res = ds.GetMassFunction(startValue, stopValue);
            Console.WriteLine("+-------+---------+");
            Console.WriteLine("|   X   |    F(x) |");
            Console.WriteLine("+-------+---------+");
            int x = startValue;
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine($"| {x,5} | {res[i],8} |");
                x++;
            }
            Console.WriteLine("+-------+---------+");


            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
