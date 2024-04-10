using JuanApp.Areas.BasicCore;
using JuanApp.Areas.JuanApp.Interfaces;
using JuanApp.Areas.JuanApp.Repositories;
using JuanApp.Areas.JuanApp.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();

            var services = new ServiceCollection();

            services.AddSingleton<IConfiguration>(configuration);

            services.AddDbContext<JuanAppContext>();

            services.AddScoped<IProductoRepository, ProductoRepository>();
            services.AddScoped<IProductoService, ProductoService>();
            

            services.AddScoped<IEntradaRepository, EntradaRepository>();
            services.AddScoped<IEntradaService, EntradaService>();

            var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(new Main(serviceProvider));
        }
    }
}