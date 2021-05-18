using ConsoleApp1.sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.repo
{
    public class CityRepo
    {
        public IModel1 contexto {set; get;}

        public CityRepo(IModel1 contexto)
        {
            this.contexto = contexto;
        }

        public List<city> ListarTodo()
        {
            var resultado=new List<city>();
            resultado=contexto.city.ToList();         
            return resultado;
        }
        public int ObtenerTotal()
        {
            city ciudad=new city {city1="nombre",country_id=4};
            city ciudad2=new city {city1="nombre",country_id=50};
            contexto.city.Add(ciudad);
            contexto.city.Add(ciudad2);
            var total=contexto.city.ToList().Sum(c=>c.country_id);
            return total;
        }
    }
}
