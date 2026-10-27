using Tyuiu.TatarinovDA.Sprint3.Task2.V7.Lib;
namespace Tyuiu.TatarinovDA.Sprint3.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;
            double expected = 81.08;
            double actual = ds.GetSumSeries(startValue, stopValue);
            Assert.AreEqual(expected, Math.Round(actual,2));
        }
    }
}
