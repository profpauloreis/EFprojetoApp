using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace EFprojetoApp.Models
{
    public class MeuDbContextFactory : IDesignTimeDbContextFactory<MeuDbContext>
    {
        public MeuDbContext CreateDbContext(string[] args) 
        {
            // Cria uma configuração para ler a string de conexão do appsettings.json
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<MeuDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            return new MeuDbContext(optionsBuilder.Options);
        }
    }
}

