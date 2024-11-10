using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MechSoft.Models
{
    
        [Table("Financeiro")]
        public class Financeiro
        {
            [Key] //anotação chave primária
            public int Id { get; set; }

            [Required]
            [Display(Name = "Data e Hora")]
            public DateTime DataHora { get; set; }

            [Required]
            public float Total_cx { get; set; }

            [StringLength(15)]
            public string Acao_finan { get; set; }

          
        }
}
