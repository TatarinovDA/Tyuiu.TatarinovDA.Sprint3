using Tyuiu.TatarinovDA.Sprint3.Task3.V3.Lib;
namespace Tyuiu.TatarinovDA.Sprint3.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMinCharCount()
        {
            
                DataService ds = new DataService();
                string value = "cvbmzff orffgtr dkfvfffd";
                char item = 'f';
                int actual = ds.GetMinCharCount(value, item);

            Assert.AreEqual(1, actual);
        
        }
    }
}
