using System.Dynamic;

namespace WebAppTest
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContextModelEntity : DbContext
    {
        public ContextModelEntity()
            : base("name=ContextModelEntity1")
        {
        }

        public virtual DbSet<Ditails> DitailsSet { get; set; }
        public virtual DbSet<StoreKeeper> StoreKeeperSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ditails>()
                .Property(e => e.NameIdCode)
                .IsUnicode(false);

            modelBuilder.Entity<Ditails>()
                .Property(e => e.NameDetails)
                .IsUnicode(false);

            modelBuilder.Entity<StoreKeeper>()
                .Property(e => e.LastFierstName)
                .IsUnicode(false);

            modelBuilder.Entity<StoreKeeper>()
                .HasMany(e => e.Ditails)
                .WithRequired(e => e.StoreKeeper1)
                .HasForeignKey(e => e.StoreKeeper)
                .WillCascadeOnDelete(true);
        }

      
    }
}
