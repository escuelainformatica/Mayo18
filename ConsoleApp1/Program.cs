using ConsoleApp1.repo;
using SimpleInjector;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var srv=new CityRepo(new sql.Model1Mockup());
            var resultado=srv.ListarTodo();

            //ClaseServicio.Ejemplo();

            //var instancia=new ClaseServicio();
            //instancia.EjemploNoEstatico();

            // contenedores y agregar inyeccion de dependencia.

            Container container = new Container();
            // solo la definicion de lo que deberia existir.
            // si necesitamos inyectar un objeto de tipo iservicio,
            // crealo usando la clase clase castellano
            container.Register<IServicio,ClaseCastellano>(Lifestyle.Scoped);
            container.Verify();

            var clasePrincipal=new ClasePrincipal(container.GetInstance<IServicio>());
            clasePrincipal.LlamarFuncion();
            clasePrincipal.MostrarSaludo();

            var clasePrincipal2=new ClasePrincipal(new ClaseIngles());
            clasePrincipal2.LlamarFuncion();
            clasePrincipal2.MostrarSaludo();



        }
    }
}
