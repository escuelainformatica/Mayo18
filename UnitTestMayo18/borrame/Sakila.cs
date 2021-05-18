using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace UnitTestMayo18.borrame
{
    public partial class Sakila : DbContext
    {
        public Sakila()
            : base("name=Sakila")
        {
        }

        public virtual DbSet<city> city { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<city>()
                .Property(e => e.city1)
                .IsUnicode(false);
        }
    }
}
