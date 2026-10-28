using Tyuiu.TatarinovDA.Sprint3.Task5.V6.Lib;
namespace Tyuiiu.TatarinovDA.Sprint3.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            // Ожидаемое математическое значение (с учетом радианной меры угла)
            double wait = -17.084;

            double res = ds.GetSumSumSeries(startValue1, startValue2, stopValue1, stopValue2);

            Assert.AreEqual(wait, res, 0.01);
        }
    }
}

