using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ConsoleApp1.sql
{
    public partial class Model1 : DbContext, IModel1
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public IDbSet<city> city { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<city>()
                .Property(e => e.city1)
                .IsUnicode(false);
        }
    }
}
