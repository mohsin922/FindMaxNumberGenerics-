using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaxNumberGenerics;

namespace FindMaxNumberMSTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [DataRow(30,20,10)]
        public void FindMax()
        {
            Program num = new Program();
            int Max = 30;
            int actual = num.FindMaximum(int first, int second, int third);
            Assert.AreEqual(Max, actual);
        }
    }
}
