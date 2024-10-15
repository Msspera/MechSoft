using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MechSoft.Models
{

	[Table("Equipamentos")]
	public class Equipamento
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(60)]
		public string Descricao { get; set; }

		[Required]
		[StringLength(60)]
		public string Estado { get; set; } // Estado de conservação do equipamento

		public DateOnly UltimaRevisao { get; set; } //TODO ajustar para ao criar, se for nulo, setar para a data atual

		public int PeriodicidadeRevisao { get; set; } // Período em meses entre cada revisão

		[NotMapped]
		public DateOnly ProximaRevisao 
		{ 
			get
			{
				return this.UltimaRevisao.AddMonths(this.PeriodicidadeRevisao);
			}
		}


		[NotMapped]
		public bool Regular // Denota se o equipamento está com a Revisão em dia, ou seja, se a data da próxima revisão ainda não chegou
		{ 
			get
			{
				return (DateOnly.FromDateTime(DateTime.Today) < this.ProximaRevisao);
			}
		} 

	}
}
