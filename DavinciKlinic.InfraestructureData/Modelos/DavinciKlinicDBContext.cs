using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace DavinciKlinic.InfraestructureData.Modelos
{
    public partial class DavinciKlinicDBContext : DbContext
    {

        //*** para acceder a appsettings cadena de conexion ***(IConfiguration configuration
      //  public IConfiguration Configuration { get; }

        public DavinciKlinicDBContext()
        {
           // Configuration = configuration;
        }

        public DavinciKlinicDBContext(DbContextOptions<DavinciKlinicDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<FacturaVenta> FacturaVenta { get; set; }
        public virtual DbSet<ItemFactura> ItemFacturas { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=DavinciKlinicDB;Trusted_Connection=True;");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
