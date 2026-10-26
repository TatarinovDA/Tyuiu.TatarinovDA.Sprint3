using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TatarinovDA.Sprint3.Task1.V4.Lib
{
    public class DataService : ISprint3Task1V4
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            int k = startValue;
            while (k <= stopValue)
            {
                double term = 1.0 / k;
                sum += Math.Pow(term, 2);
                k++;
            }
            return Math.Round(sum,2);

        }
    }
}
