using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mayo18.servicio
{
    public class ClaseServicio
    {
        public static string CompararValores(int n1,int n2)
        {
            if(n1<n2)
            {
                return "n1 es menor";
            }
            return "n2 es menor";
        }
        public static int SumarValores(int n1,int n2)
        {
            if(n1>=Int32.MaxValue)
            {
                return 0;
            }
            return n1+n2;
        }
    }
}