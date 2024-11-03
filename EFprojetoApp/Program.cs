using EFprojetoApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace EFprojetoApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Configura��o do servi�o
            var services = new ServiceCollection();
            ConfigureServices(services);

            // Cria��o do ServiceProvider
            var serviceProvider = services.BuildServiceProvider();

            // Iniciar o aplicativo
            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // Configurar a leitura do appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            // Configura��o do DbContext
            services.AddDbContext<MeuDbContext>(options =>
                options.UseSqlServer("DefaultConnection")); // Substituir pela string de conex�o

            // Registre outros servi�os, como formul�rios
            services.AddTransient<Form1>(); // Exemplo de registo de um formul�rio
        }
    }
}