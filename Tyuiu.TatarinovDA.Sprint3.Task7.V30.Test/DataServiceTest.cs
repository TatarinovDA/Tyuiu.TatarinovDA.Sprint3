using Tyuiu.TatarinovDA.Sprint3.Task7.V30.Lib;
namespace Tyuiu.TatarinovDA.Sprint3.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] wait = new double[] { -15.60,
                                           -12.35,
                                           -10.72,
                                           -8.88,
                                           -2.16,
                                            3.25,
                                            6.64,
                                            10.30,
                                            16.17,
                                            28.10,
                                            38.41 };
            double[] res = ds.GetMassFunction(startValue, stopValue);
            Assert.AreEqual(wait.Length, res.Length); 
            for (int i = 0; i < wait.Length; i++)
            {
                Assert.AreEqual(wait[i], res[i], 0.01);
            }
        }
    }
}
