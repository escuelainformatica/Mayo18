using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.sql
{
    class Model1Mockup : IModel1
    {
        public virtual IDbSet<city> city { get; set; }=new FakeDbSet<city>();
    }
}
