using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Quiron.LojaVirtual.Dominio;
using Quiron.LojaVirtual.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class EfDbContext : DbContext
    {
        public EfDbContext()
        {

        }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produtos");
        }        
    }
}
