using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using JuanApp.Areas.JuanApp.Entities;
using JuanApp.Areas.JuanApp.EntitiesConfiguration;
using JuanApp.Areas.System.Entities;
using JuanApp.Areas.System.EntitiesConfiguration;

namespace JuanApp.DatabaseContexts
{
    public class JuanAppContext : DbContext
    {
        protected IConfiguration _configuration { get; }

        public DbSet<Failure> Failure { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Remito> Remito { get; set; }
        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<Salida> Salida { get; set; }

        public JuanAppContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                string ConnectionString = "";
#if DEBUG
                ConnectionString = _configuration.GetConnectionString("Debug");
#else
                string IP = "192.168.28.14";
                string Server = "sql4.baehost.com";
                ConnectionString = _configuration.GetConnectionString("Release");

#endif

                optionsBuilder
                    .UseSqlServer(ConnectionString);
            }
            catch (Exception) { throw; }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            try
            {
                modelBuilder.ApplyConfiguration(new FailureConfiguration());
                modelBuilder.ApplyConfiguration(new ProductoConfiguration());
                modelBuilder.ApplyConfiguration(new RemitoConfiguration());
                modelBuilder.ApplyConfiguration(new ClienteConfiguration());
                modelBuilder.ApplyConfiguration(new EntradaConfiguration());
                modelBuilder.ApplyConfiguration(new SalidaConfiguration());
            }
            catch (Exception) { throw; }
        }
    }
}
