using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MechSoft.Models
{
	
	public enum EtapasAtendimento
	{
		Chegada,
		Operacao,
		Entrega
	}
	public enum CategoriasAtendimento
	{
		Manutencao,
		Rotina
	}

	public class Atendimento
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public EtapasAtendimento Etapa { get; set; }
		[Required]
		public CategoriasAtendimento Categoria { get; set; }

		[Required]
		public String BriefingChegada { get; set; }

		public List<Avaria> Avarias { get; set; } = new List<Avaria>();




	}

	[NotMapped]
	public class Avaria
	{
		public String Descricao { get; set; }
		public bool CompeteAoMecanico { get; set; }
	}
}
