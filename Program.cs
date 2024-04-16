using JuanApp.Areas.BasicCore;
using JuanApp.Areas.BasicCore.Interfaces;
using JuanApp.Areas.BasicCore.Repositories;
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

            services.AddScoped<IFailureRepository, FailureRepository>();

            services.AddScoped<IProductoRepository, ProductoRepository>();
            services.AddScoped<IProductoService, ProductoService>();

            services.AddScoped<IRemitoRepository, RemitoRepository>();
            services.AddScoped<IRemitoService, RemitoService>();

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteService, ClienteService>();

            services.AddScoped<IEntradaRepository, EntradaRepository>();
            services.AddScoped<IEntradaService, EntradaService>();

            services.AddScoped<ISalidaRepository, SalidaRepository>();
            services.AddScoped<ISalidaService, SalidaService>();

            var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(new Main(serviceProvider));
        }
    }
}