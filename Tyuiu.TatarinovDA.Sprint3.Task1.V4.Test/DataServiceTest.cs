using Tyuiu.TatarinovDA.Sprint3.Task1.V4.Lib;
namespace Tyuiu.TatarinovDA.Sprint3.Task1.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;
            double wait = 1.549767;
            double res = ds.GetSumSeries(startValue, stopValue);
            Assert.AreEqual(Math.Round(wait,5), Math.Round(res,5));
        }
    }
}
