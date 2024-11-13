using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MechSoft.Models
{
	[Table("Clientes")]
	public class Cliente
	{
		[Key] //anotação chave primária
		public int Id { get; set; }

		[Required]
		[StringLength(90)]
		[Display(Name="Nome")]
		public string Nome { get; set; }

		[Required]
		[StringLength(11)]
		public string Celular { get; set; }

		[StringLength(120)]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		[StringLength(120)]
		public string Endereco { get; set; }

		[InverseProperty("Cliente")]
		public List<Atendimento> Atendimentos { get; set; }

	}
}
