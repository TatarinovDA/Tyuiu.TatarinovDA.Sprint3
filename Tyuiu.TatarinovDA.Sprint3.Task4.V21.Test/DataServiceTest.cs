using Tyuiu.TatarinovDA.Sprint3.Task4.V21.Lib;
namespace Tyuiu.TatarinovDA.Sprint3.Task4.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double wait = 0.586;
            double res = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(wait, res, 0.0001);
        }
    }
}
