using ConsoleApp1.repo;
using ConsoleApp1.sql;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var repo=new CityRepo(new Model1Mockup());

            Assert.AreEqual(0,repo.ListarTodo().Count);

            Assert.AreEqual(54,repo.ObtenerTotal());

        }
    }
}
