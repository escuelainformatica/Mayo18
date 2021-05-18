using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mayo18.DB
{
    public class SakilaMockup : ISakila
    {
        public virtual IDbSet<city> city { get; set; }=new FakeDbSet<city>();


    }
}