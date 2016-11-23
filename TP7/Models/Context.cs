using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace TP7.Models
{
    public class Context : DbContext
    {

        public DbSet<ArticulosModels> Articulo { get; set; }
        public DbSet<FacturasModels> Factura { get; set; }
        public DbSet<DetallesModels> Detalle { get; set; }

        static Context()
        {
            Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());
            // Database.SetInitializer<Context>(new DropCreateDatabaseAlways<Context>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}