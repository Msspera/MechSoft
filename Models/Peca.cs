using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MechSoft.Models
{
	[Table("Pecas")]
	public class Peca
	{

		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(60)]
		public string Descricao { get; set; }

		[Required]
		[StringLength(60)]
		public string Fornecedor { get; set; }

		[Required]
		public int Estoque { get; set; }

	}
}
