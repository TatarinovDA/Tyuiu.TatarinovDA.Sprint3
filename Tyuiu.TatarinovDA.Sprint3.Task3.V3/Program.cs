using Tyuiu.TatarinovDA.Sprint3.Task3.V3.Lib;
// 

namespace Tyuiu.TatarinovDA.Sprint3.Task3.V3
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Татаринов Данил Андреевич | ИСТНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach, подсчитать минимальное количество               *");
            Console.WriteLine("* подряд идущих символов.                                                 *");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string inputString = "cvbmzff orffgtrr dkfvfffdr";
            char targetChar = 'f';





            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.GetMinCharCount(inputString, targetChar);
            Console.WriteLine($"* Строка: {inputString}                                      *");
            Console.WriteLine($"* Искомый символ: '{targetChar}'                                                     *");
            Console.WriteLine($"* Минимальное количество подряд: {result}                                        *");


            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }

}
