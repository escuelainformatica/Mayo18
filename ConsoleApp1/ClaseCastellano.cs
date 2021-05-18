using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ClaseCastellano : IServicio
    {
        public string campoNoEstatico;
        public void EjemploNoEstatico()
        {
            campoNoEstatico="hola";
            Debug.WriteLine("-------------------");
            Debug.WriteLine("- "+campoNoEstatico+" -");
            Debug.WriteLine("-------------------");
        }

        public void MostrarSaludo()
        {
            Debug.WriteLine("Hola mundo");
        }
    }
}
