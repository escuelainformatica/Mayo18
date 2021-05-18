using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ClaseIngles : IServicio
    {


        public string campoNoEstatico;
        public void EjemploNoEstatico()
        {
            campoNoEstatico = "hola";
            Debug.WriteLine(campoNoEstatico);
        }

        public void MostrarSaludo()
        {
            Debug.WriteLine("Hello world");
        }
    }
}
