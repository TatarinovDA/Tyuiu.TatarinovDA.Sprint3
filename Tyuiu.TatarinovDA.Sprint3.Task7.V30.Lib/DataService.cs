using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TatarinovDA.Sprint3.Task7.V30.Lib
{
    public class DataService : ISprint3Task7V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = Math.Abs(stopValue - startValue) + 1;
            double[] result = new double[count];
            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Sin(x) + 2;
                double fValue;
                if (denominator == 0)
                {
                    fValue = 0;
                }
                else
                {
                    fValue = (5.0 * x + 2.5) / denominator + 2.0 * x + 2.0;
                }
                result[index] = Math.Round(fValue, 2);
                index++;
            }
            return result;
        }
    }
}
