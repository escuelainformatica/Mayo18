using Mayo18.servicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestMayo18
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("n1 es menor",ClaseServicio.CompararValores(1,10));
            Assert.AreEqual("n2 es menor",ClaseServicio.CompararValores(10,2));

            Assert.AreEqual(2,ClaseServicio.SumarValores(1,1));

            Assert.AreEqual(0,ClaseServicio.SumarValores(Int32.MaxValue,Int32.MaxValue));
        }
    }
}
