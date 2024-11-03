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

            // Configuração do serviço
            var services = new ServiceCollection();
            ConfigureServices(services);

            // Criação do ServiceProvider
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

            // Configuração do DbContext
            services.AddDbContext<MeuDbContext>(options =>
                options.UseSqlServer("DefaultConnection")); // Substituir pela string de conexão

            // Registre outros serviços, como formulários
            services.AddTransient<Form1>(); // Exemplo de registo de um formulário
        }
    }
}