using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Mayo18.DB
{
    public partial class Sakila : DbContext,ISakila
    {
        public Sakila()
            : base("name=Sakila")
        {
        }

        public virtual IDbSet<city> city { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<city>()
                .Property(e => e.city1)
                .IsUnicode(false);
        }
    }
}
