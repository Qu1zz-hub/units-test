using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sus;
using System;
namespace ss.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void drob_10and5_2returned()
        {
            // arrange
            int x = 10;
            int y = 5;
            int expected = 2;
            // act
            xiaomi c = new xiaomi();
            int actual = c.drob(x, y);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
