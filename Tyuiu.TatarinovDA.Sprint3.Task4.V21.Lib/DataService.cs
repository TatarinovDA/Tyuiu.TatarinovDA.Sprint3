using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TatarinovDA.Sprint3.Task4.V21.Lib
{
    public class DataService : ISprint3Task4V21
    {
        public double Calculate(int startValue, int stopValue)
        {
            double product = 1.0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }
                double y = (Math.Cos(x) - x) / x;
                product *= y;
            }
            return Math.Round(product,3);
        }

        
    }
}
