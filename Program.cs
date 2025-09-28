using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PruebaTecnica.Data;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Forms;
using PruebaTecnica.Data.Repositories;
using PruebaTecnica.Services;
using PruebaTecnica.Interfaces;


namespace PruebaTecnica
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configuración
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            var configuration = builder.Build();

            // Inyección de dependencias
            var services = new ServiceCollection();
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Registros con interfaces
            services.AddScoped<IEmpresaRepository, EmpresaRepository>();
            services.AddScoped<IEmpresaService, EmpresaService>();

            // Formularios
            services.AddTransient<FormCompanyList>();
            services.AddTransient<FormCompanyEditor>();

            var provider = services.BuildServiceProvider();

            // Migraciones al arranque
            using (var scope = provider.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                db.Database.Migrate();
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(provider.GetRequiredService<FormCompanyList>());
        }
    }
}