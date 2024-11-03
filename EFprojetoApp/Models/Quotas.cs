using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFprojetoApp.Models
{
    public class Quotas
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Socio")]
        public int SocioId { get; set; }
        [Required]
        
        public DateTime DataPagamento { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        public virtual Socios Socio { get; set; }
    }
}

