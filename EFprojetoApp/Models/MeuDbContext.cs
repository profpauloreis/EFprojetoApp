using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFprojetoApp.Models
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options)
        {
        }

        public DbSet<Socios> Socios { get; set; } = null!; // Inicialização com null!
        public DbSet<Quotas> Quotas { get; set; } = null!; // Inicialização com null!
    }
}
