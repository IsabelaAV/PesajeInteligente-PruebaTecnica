using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PruebaTecnica.Data;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Forms;


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

            services.AddTransient<FormCompanyList>();

            var provider = services.BuildServiceProvider();

            // Ejecutar migraciones al arrancar
            using (var scope = provider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                context.Database.Migrate();
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormCompanyList());
        }
    }
}