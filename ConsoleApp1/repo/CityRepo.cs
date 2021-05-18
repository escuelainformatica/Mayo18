using ConsoleApp1.sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.repo
{
    class CityRepo
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
    }
}
