using Datos_Delfin.Migrations;
using System.Data.Entity;

namespace Datos_Delfin
{
    public class DelfinContext : DbContext
    {
        public DelfinContext() : base("DelfinContext")
        {
            Database.SetInitializer<DelfinContext>(
             new MigrateDatabaseToLatestVersion<DelfinContext, Configuration>());
        }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<DetalleCompra> DetalleCompras { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
    }
}
