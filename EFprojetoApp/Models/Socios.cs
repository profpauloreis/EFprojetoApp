using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFprojetoApp.Models
{
    public class Socios
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        public DateTime DataDeEntrada { get; set; }


        public virtual ICollection<Quotas> Quotas { get; set; }

        public Socios()
        {
            Quotas = new HashSet<Quotas>();
        }
    }
}
