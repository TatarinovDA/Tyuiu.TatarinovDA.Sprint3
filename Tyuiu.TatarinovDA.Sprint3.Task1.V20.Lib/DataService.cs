using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TatarinovDA.Sprint3.Task1.V20.Lib
{
    public class DataService : ISprint3Task1V20
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double p = 1;
            double x = 1;
            for (int k = startValue; k <= stopValue; k++)
            {
                double term = Math.Cos(x) + Math.Pow(k / 8.0, 3);
                p *= term;
            }
            return p;
            
        }
    }
}
