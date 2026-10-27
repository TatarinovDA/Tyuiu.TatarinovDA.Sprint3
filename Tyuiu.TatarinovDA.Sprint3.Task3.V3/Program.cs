using Tyuiu.TatarinovDA.Sprint3.Task3.V3.Lib;
// 
namespace Tyuiiu.TatarinovDA.Sprint3.Task3.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "cvbmzff orffgtrr dkfvfffdr";
            char targetChar = 'f';

            DataService ds = new DataService();

            int result = ds.GetMinCharCount(inputString, targetChar);

            Console.WriteLine("Задание: Используя цикл foreach, подсчитать минимальное количество подряд идущих символов.");
            Console.WriteLine($"Строка: {inputString}");
            Console.WriteLine($"Искомый символ: '{targetChar}'");
            Console.WriteLine($"Минимальное количество подряд: {result}");

            Console.ReadLine();
        }
    }
}