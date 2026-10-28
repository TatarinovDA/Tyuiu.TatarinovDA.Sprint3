using Tyuiu.TatarinovDA.Sprint3.Task6.V24.Lib;
namespace Tyuiu.TatarinovDA.Sprint3.Task6.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 17;
            int stopValue = 26;
            int wait = 41;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
