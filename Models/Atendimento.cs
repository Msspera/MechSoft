using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MechSoft.Models
{
	/*
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
	}*/

	public class Atendimento
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public String? Etapa { get; set; }
		[Required]
		public String? Categoria { get; set; }

		public String? BriefingChegada { get; set; }

		public String? AvariasCompetentesMecanico { get; set; }

		public String? AvariasNaoCompetentesMecanico { get; set; }

	}

}
