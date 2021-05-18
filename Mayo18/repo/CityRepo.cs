using Mayo18.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mayo18.repo
{
    public class CityRepo
    { 
        public ISakila contexto {set; get;}

        public CityRepo(ISakila contexto)
        {
            this.contexto = contexto;

        }

        public List<city> ListarTodo()
        {
            return contexto.city.ToList();
        }
    }
}