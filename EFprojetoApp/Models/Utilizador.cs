using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFprojetoApp.Models
{
    public class Utilizador
    {
        [Key] // Define a chave primária
        public int UtilizadorId { get; set; }
        [Required] // Indica que o campo é obrigatório
        [StringLength(100)] // Define o tamanho máximo do campo
        public string Nome { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        public string Telefone { get; set; }

    }
}
