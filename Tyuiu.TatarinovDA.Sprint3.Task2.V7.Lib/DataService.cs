using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TatarinovDA.Sprint3.Task2.V7.Lib
{
    public class DataService : ISprint3Task2V7
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            int k = startValue;
            do
            {
                double term = Math.Pow(1.0 / Math.Sin(k), 2);
                sum += term;
                k++;
            }
            while (k <= stopValue);
            return sum;
            

        }
    }
}
