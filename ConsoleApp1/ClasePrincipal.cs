using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ClasePrincipal
    {
        public IServicio servicio {set; get;}

        public ClasePrincipal(IServicio srv)
        {
            servicio=srv;
        }

        public void LlamarFuncion()
        {
            servicio.EjemploNoEstatico();
        }
        public void MostrarSaludo()
        {
            servicio.MostrarSaludo();
        }

    }
}
