namespace Opiskelijat
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OpiskelijatContext : DbContext
    {
        public OpiskelijatContext()
            : base("name=OpiskelijatDataConnectionSettings")
        {
        }

        public virtual DbSet<opiskelijat> opiskelijat { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<opiskelijat>()
                .Property(e => e.Opiskelija)
                .IsUnicode(false);

            modelBuilder.Entity<opiskelijat>()
                .Property(e => e.Tila)
                .IsUnicode(false);
        }
    }
}
