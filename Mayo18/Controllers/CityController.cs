using Mayo18.DB;
using Mayo18.repo;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mayo18.Controllers
{    
    public class CityController : Controller
    {
        public ISakila contexto {set; get;}

        public CityController(ISakila contexto) // new Sakila()
        {
            this.contexto = contexto;
        }

        // GET: City
        public ActionResult Index()
        {
            var db=new CityRepo(contexto);
            ViewBag.lista=db.ListarTodo();
            return View();
        }

        public ActionResult Index2()
        {
            var db=new CityRepo(contexto);
            var lista=db.ListarTodo();
            return View();
        }
    }
}