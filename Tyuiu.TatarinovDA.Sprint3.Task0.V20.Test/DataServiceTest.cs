using Tyuiu.TatarinovDA.Sprint3.Task0.V20.Lib;
namespace Tyuiu.TatarinovDA.Sprint3.Task0.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetGetMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int stopValue = 14;
            double expected = 287.18;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            Assert.AreEqual(expected, res, 0.001);
        }
    }
}
