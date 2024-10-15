using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MechSoft.Models
{
	[Table("Carros")]
	public class Carro
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(60)]
		public string Modelo { get; set; }

		[Required]
		[StringLength(50)]
		public string Marca { get; set; }

		[Required, StringLength(7)]
		public string Placa { get; set; }

		[StringLength(30)]
		public string Cor { get; set; }


	}
}
