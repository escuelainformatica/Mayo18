using Mayo18.Controllers;
using Mayo18.DB;
using Mayo18.repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestMayo18
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var repo=new CityRepo(new SakilaMockup());

            Assert.AreEqual(0,repo.ListarTodo().Count);

        }

        [TestMethod]
        public void TestIntegracion()
        {
            var repo=new CityRepo(new Sakila());

            Assert.AreEqual(600,repo.ListarTodo().Count);
        }
        [TestMethod]
        public void TestControlador()
        {
            var controlador=new CityController(new SakilaMockup());

            Assert.AreEqual("System.Web.Mvc.ViewResult"
                ,controlador.Index().ToString());
        }
    }
}
