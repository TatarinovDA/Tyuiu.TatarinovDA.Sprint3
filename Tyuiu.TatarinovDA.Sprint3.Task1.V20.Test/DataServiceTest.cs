using Tyuiu.TatarinovDA.Sprint3.Task1.V20.Lib;
namespace Tyuiu.TatarinovDA.Sprint3.Task1.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 14;
            double expected = 287.18013792479553;
            double res = ds.GetSumSeries(startValue, stopValue);
            Assert.AreEqual(expected, res, 0.001);
        }
    }
}
