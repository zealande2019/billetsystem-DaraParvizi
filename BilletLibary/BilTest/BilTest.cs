using BilletLibary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilTest
{
    [TestClass]
    public class BilTest
    {
        [TestMethod]
        public void BilPrisTest()
        {
            var bil = new Bil();

            decimal pris = bil.Pris();

            Assert.AreEqual(240, pris);
        }
    }
}
